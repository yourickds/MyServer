using MyServer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MyServer
{
    public partial class Form4 : Form
    {
        public MyProgram? Program;
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                using (var context = new Configs.DataBase())
                {
                    if (Program != null)
                    {
                        Program.Name = textBox1.Text;
                        Program.FilePath = textBox2.Text;
                        Program.Argument = !string.IsNullOrEmpty(textBox3?.Text) ? textBox3.Text.Trim() : null;
                        context.Entry(Program).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                        var StoreProgram = Store.Programs.Single(p => p.Id == Program.Id);
                        StoreProgram = Program;
                        Store.Programs.ResetBindings();
                    }
                    else
                    {
                        var program = new MyProgram()
                        {
                            Name = textBox1.Text,
                            FilePath = textBox2.Text,
                            Argument = !string.IsNullOrEmpty(textBox3?.Text) ? textBox3.Text.Trim() : null
                        };
                        context.Programs.Add(program);
                        context.SaveChanges();
                        Store.Programs.Add(program);
                    }
                }
                Close();
            }
        }

        private bool ValidateForm()
        {
            bool validate = true;
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(label1, "Поле обязательно для заполнения");
                validate = false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider2.SetError(label2, "Поле обязательно для заполнения");
                validate = false;
            }
            else
            {
                var folder = new FileInfo(textBox2.Text.Trim());
                if (String.IsNullOrEmpty(folder.FullName))
                {
                    errorProvider2.SetError(label2, "Неккоректный файл");
                    validate = false;
                }
                else
                {
                    errorProvider2.Clear();
                }
            }
            return validate;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox2.Text = openFileDialog1.FileName;
        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            if (Program != null)
            {
                Text = "Редактирование программы";
                button1.Text = "Сохранить";
                textBox1.Text = Program.Name;
                textBox2.Text = Program.FilePath;
                textBox3.Text = Program.Argument;
            }
        }
    }
}
