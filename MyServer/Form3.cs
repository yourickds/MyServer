using MyServer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyServer
{
    public partial class Form3 : Form
    {
        public Config? config;
        private readonly Module Module;
        public Form3(Module Module)
        {
            InitializeComponent();
            this.Module = Module;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    using (var context = new Configs.DataBase())
                    {
                        if (config != null)
                        {
                            config.Name = textBox2.Text;
                            config.FilePath = textBox1.Text.Trim();
                            config.Module = this.Module;
                            config.Hidden = checkBox1.Checked;
                            config.Startup = checkBox2.Checked;
                            config.Argument = !string.IsNullOrEmpty(textBox3?.Text) ? textBox3.Text.Trim() : null;
                            context.Entry(config).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                            context.SaveChanges();
                            var storeConfig = Store.Configs.Single(c => c.Id == config.Id);
                            storeConfig = config;
                            Store.Configs.ResetBindings();
                            Store.Startup.ResetBindings();
                        }
                        else
                        {
                            var config = new Config()
                            {
                                Name = textBox2.Text,
                                FilePath = textBox1.Text.Trim(),
                                Module = this.Module,
                                Hidden = checkBox1.Checked,
                                Startup = checkBox2.Checked,
                                Argument = !string.IsNullOrEmpty(textBox3?.Text) ? textBox3.Text.Trim() : null
                            };
                            context.Modules.Attach(this.Module);
                            context.Configs.Add(config);
                            context.SaveChanges();
                            Store.Configs.Add(config);
                        }
                    }
                    Close();
                }
                else
                {
                    errorProvider1.SetError(textBox1, "Поле обязательно для заполнения");
                }
            }
            else
            {
                errorProvider1.SetError(textBox2, "Поле обязательно для заполнения");
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var folder = new FileInfo(openFileDialog1.FileName);
            textBox1.Text = folder.FullName;
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            if (config != null)
            {
                textBox2.Text = config.Name;
                textBox1.Text = config.FilePath;
                textBox3.Text = config.Argument;
                checkBox1.Checked = config.Hidden;
                checkBox2.Checked = config.Startup;
            }
        }
    }
}
