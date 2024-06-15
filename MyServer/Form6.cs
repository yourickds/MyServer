using MyServer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyServer
{
    public partial class Form6 : Form
    {
        public Domains? Domain;
        public Form6()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                using (var context = new Configs.DataBase())
                {
                    if (Domain != null)
                    {
                        Domain.Url = textBox1.Text;
                        context.Entry(Domain).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                        var StoreDomain = Store.Domains.Single(d => d.Id == Domain.Id);
                        StoreDomain = Domain;
                        Store.Domains.ResetBindings();
                    }
                    else
                    {
                        var domain = new Domains()
                        {
                            Url = textBox1.Text,
                            GenerateVHost = false,
                        };
                        context.Domains.Add(domain);
                        context.SaveChanges();
                        Store.Domains.Add(domain);
                    }
                }
                Close();
            }
        }

        private bool ValidateForm()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(label1, "Поле обязательно для заполнения");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            return true;
        }

        private void Form6_Shown(object sender, EventArgs e)
        {
            if (Domain != null)
            {
                Text = "Редактирование домена";
                button1.Text = "Сохранить";
                textBox1.Text = Domain.Url;
            }
        }
    }
}
