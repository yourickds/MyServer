namespace MyServer
{
    public partial class FormNewModule : Form
    {
        public Model.Module? module;
        public FormNewModule()
        {
            InitializeComponent();
        }
        private void CloseDialogNewModule(object sender, EventArgs e)
        {
            Close();
        }
        private void AddModule(object sender, EventArgs e)
        {
            // Если поле с новым именем не равно null и не пустое
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                using (var context = new Configs.DataBase())
                {
                    if (module != null)
                    {
                        var storeModule = Store.Modules.Single(p => p.Id == module.Id);
                        module.Name = textBox1.Text.Trim();
                        context.Entry(module).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                        storeModule.Name = module.Name;
                    }
                    else
                    {
                        var module = new Model.Module() { Name = textBox1.Text.Trim() };
                        context.Modules.Add(module);
                        context.SaveChanges();
                        Store.Modules.Add(module);
                    }
                    Store.Modules.ResetBindings();
                    Store.Configs.ResetBindings();
                    Store.Startup.ResetBindings();
                }
                Close();
            }
            else
            {
                errorProvider1.SetError(textBox1, "Поле обязательно для заполнения");
            }
        }
        private void FormNewModule_Shown(object sender, EventArgs e)
        {
            if (module != null) { 
                this.Text = "Редактирование модуля";
                textBox1.Text = module.Name;
                button1.Text = "Сохранить";
            }
        }
    }
}
