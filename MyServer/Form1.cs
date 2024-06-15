using MyServer.Model;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MyServer
{
    public partial class Form1 : Form
    {
        private readonly List<Process> Processess = [];
        private bool StatusServer = false;
        private string EnvironmentPath = "";
        public Form1()
        {
            InitializeComponent();

            ComboBoxModule.DataSource = Store.Modules;
            ComboBoxModule.DisplayMember = "Name";
            ComboBoxModule.ValueMember = "Id";

            ComboBoxConfig.DataSource = Store.Configs;
            ComboBoxConfig.DisplayMember = "FullName";
            ComboBoxConfig.ValueMember = "Id";

            listBoxStartupModules.DataSource = Store.Startup;
            listBoxStartupModules.DisplayMember = "FullName";
            listBoxStartupModules.ValueMember = "Id";

            comboBox1.DataSource = Store.Programs;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            comboBox2.DataSource = Store.Bookmarks;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";

            comboBox3.DataSource = Store.Domains;
            comboBox3.DisplayMember = "Url";
            comboBox3.ValueMember = "Id";
        }
        private void ButtonAddModuleForm_Click(object sender, EventArgs e)
        {
            var form = new FormNewModule();
            form.ShowDialog();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (ComboBoxModule.SelectedItem != null && ComboBoxModule.SelectedItem is Model.Module selected)
            {
                Store.Modules.Remove(selected);
                using var context = new Configs.DataBase();
                context.Modules.Remove(selected);
                context.SaveChanges();
            }
        }
        private void ButtonAddConfigForm_Click(object sender, EventArgs e)
        {
            if (ComboBoxModule.SelectedItem != null && ComboBoxModule.SelectedItem is Model.Module selected)
            {
                var form = new Form3(selected);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите модуль", "Ошибка");
            }
        }
        private void ComboBoxModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем конфиги данного модуля
            if (ComboBoxModule.SelectedItem != null && ComboBoxModule.SelectedItem is Model.Module selected)
            {
                Store.Configs.Clear();
                if (selected.Configs != null)
                {
                    foreach (var config in selected.Configs)
                    {
                        Store.Configs.Add(config);
                    }
                }
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (ComboBoxConfig.SelectedItem != null && ComboBoxConfig.SelectedItem is Model.Config selected)
            {
                Store.Configs.Remove(selected);
                using var context = new Configs.DataBase();
                context.Configs.Remove(selected);
                context.SaveChanges();
            }
        }
        private void ButtonAddConfigToListStartup_Click(object sender, EventArgs e)
        {
            if (ComboBoxConfig.SelectedItem != null && ComboBoxConfig.SelectedItem is Model.Config selected)
            {
                Store.Startup.Add(selected);
                string rpath = selected.FilePath.Replace("%myserverdir%", Directory.GetCurrentDirectory());
                var path = new FileInfo(rpath);
                EnvironmentPath += path.DirectoryName + ";";
            }
        }
        private void ButtonServer_Click(object sender, EventArgs e)
        {
            if (StatusServer)
                StopServer();
            else
                StartServer();
        }

        private void StartServer()
        {
            if (Processess.Count > 0)
            {
                StopServer();
            }
            Environment.SetEnvironmentVariable("PATH", EnvironmentPath);
            foreach (var config in Store.Startup)
            {
                if (config.Startup)
                {
                    //MessageBox.Show(config.File);
                    var process = new Process();
                    process.StartInfo.FileName = config.FilePath.Replace("%myserverdir%", Directory.GetCurrentDirectory());
                    process.StartInfo.UseShellExecute = true;
                    if (!String.IsNullOrEmpty(config.Argument))
                    {
                        process.StartInfo.Arguments = config.Argument.Replace("%myserverdir%", Directory.GetCurrentDirectory());
                    }
                    if (config.Hidden)
                        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    else
                        process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    if (process.Start())
                    {
                        MessageBox.Show(config.FilePath);
                        Processess.Add(process);
                    }

                }
            }
            StatusServer = true;
            ButtonServer.Text = "Остановить сервер";
        }

        private void StopServer()
        {
            foreach (var process in Processess)
            {
                process.Kill(true);
            }
            Processess.Clear();
            StatusServer = false;
            ButtonServer.Text = "Запустить сервер";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("PATH", EnvironmentPath);
            var process = new Process();
            process.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "/System32/cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                Hide();
                notifyIcon1.BalloonTipText = "Приложение все еще запущено!";
                notifyIcon1.ShowBalloonTip(150);
            }
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var notepad = new Process();
            notepad.StartInfo.FileName = "notepad.exe";
            notepad.StartInfo.Arguments = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "/System32/drivers/etc/hosts";
            notepad.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            notepad.StartInfo.Verb = "runas";
            notepad.StartInfo.UseShellExecute = true;
            notepad.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (StatusServer)
                StopServer();
            MessageBox.Show("Good By", "Closing");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (ComboBoxModule.SelectedItem != null && ComboBoxModule.SelectedItem is Model.Module selected)
            {
                var form = new FormNewModule
                {
                    module = selected
                };
                form.ShowDialog();
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (ComboBoxConfig.SelectedItem != null && ComboBoxConfig.SelectedItem is Model.Config selected)
            {
                var form = new Form3(selected.Module)
                {
                    config = selected
                };
                form.ShowDialog();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (listBoxStartupModules.SelectedItem != null && listBoxStartupModules.SelectedItem is Model.Config selected)
            {
                Store.Startup.Remove(selected);
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            var form = new Form4();
            form.ShowDialog();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem is Model.MyProgram selected)
            {
                var form = new Form4()
                {
                    Program = selected
                };
                form.ShowDialog();
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem is Model.MyProgram selected)
            {
                Store.Programs.Remove(selected);
                using var context = new Configs.DataBase();
                context.Programs.Remove(selected);
                context.SaveChanges();
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem is Model.MyProgram selected)
            {
                Environment.SetEnvironmentVariable("PATH", EnvironmentPath);

                var process = new Process();
                process.StartInfo.FileName = selected.FilePath;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.Arguments = selected.Argument;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            var form = new Form5();
            form.ShowDialog();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem is Model.Bookmark selected)
            {
                var form = new Form5()
                {
                    Bookmark = selected
                };
                form.ShowDialog();
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem is Model.Bookmark selected)
            {
                Store.Bookmarks.Remove(selected);
                using var context = new Configs.DataBase();
                context.Bookmarks.Remove(selected);
                context.SaveChanges();
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem is Model.Bookmark selected)
            {
                var process = new Process();
                process.StartInfo.FileName = selected.Url;
                process.StartInfo.UseShellExecute = true;
                process.Start();
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            var form = new Form6();
            form.ShowDialog();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null && comboBox3.SelectedItem is Model.Domains selected)
            {
                Store.Domains.Remove(selected);
                using var context = new Configs.DataBase();
                context.Domains.Remove(selected);
                context.SaveChanges();
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null && comboBox3.SelectedItem is Model.Domains selected)
            {
                var form = new Form6()
                {
                    Domain = selected
                };
                form.ShowDialog();
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null && comboBox3.SelectedItem is Model.Domains selected)
            {
                var process = new Process();
                process.StartInfo.FileName = selected.Url;
                process.StartInfo.UseShellExecute = true;
                process.Start();
            }
        }
    }
}
