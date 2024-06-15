using MyServer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
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
                        Domain.Name = textBox1.Text;
                        Domain.DirectoryRoot = textBox2.Text;
                        context.Entry(Domain).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                        var StoreDomain = Store.Domains.Single(d => d.Id == Domain.Id);
                        StoreDomain = Domain;
                        Store.Domains.ResetBindings();
                        CreateVhost(Domain.Name, Domain.DirectoryRoot);
                    }
                    else
                    {
                        var domain = new Domains()
                        {
                            Name = textBox1.Text,
                            DirectoryRoot = textBox2.Text,
                        };
                        context.Domains.Add(domain);
                        context.SaveChanges();
                        Store.Domains.Add(domain);
                        CreateVhost(domain.Name, domain.DirectoryRoot);
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
                textBox1.Text = Domain.Name;
                textBox2.Text = Domain.DirectoryRoot;
            }
        }

        private static void CreateVhost(string ServerName, string DocumentRoot)
        {
            if (File.Exists("userdata/vhosts/" + ServerName + ".conf"))
                File.Delete("userdata/vhosts/" + ServerName + ".conf");


            string content = "<VirtualHost *:80>\r\n    ServerAdmin admin@mailer.ru\r\n    DocumentRoot \"" + Directory.GetCurrentDirectory() + "/domains/" + ServerName + "/public\"\r\n    ServerName " + ServerName + "\r\n    ErrorLog \"" + Directory.GetCurrentDirectory() + "/userdata/logs/vhosts/"+ServerName+"-error.log\"\r\n    CustomLog \""+Directory.GetCurrentDirectory()+"/userdata/logs/vhosts/"+ServerName+"-access.log\" common\r\n    \r\n    DirectoryIndex index.php index.html\r\n\r\n    <Directory "+Directory.GetCurrentDirectory()+"/domains/"+ServerName+DocumentRoot+">\r\n        Options Indexes FollowSymLinks\r\n        AllowOverride All\r\n        Require all granted\r\n    </Directory>\r\n</VirtualHost>";
            StreamWriter writer = new("userdata/vhosts/" + ServerName + ".conf");
            writer.Write(content);
            writer.Close();
        }
    }
}
