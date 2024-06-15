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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyServer
{
    public partial class Form5 : Form
    {
        public Bookmark? Bookmark;
        public Form5()
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
                    if (Bookmark != null)
                    {
                        Bookmark.Name = textBox1.Text;
                        Bookmark.Url = textBox2.Text;
                        context.Entry(Bookmark).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();
                        var StoreBookmark = Store.Bookmarks.Single(b => b.Id == Bookmark.Id);
                        StoreBookmark = Bookmark;
                        Store.Bookmarks.ResetBindings();
                    }
                    else
                    {
                        var bookmark = new Bookmark()
                        {
                            Name = textBox1.Text,
                            Url = textBox2.Text
                        };
                        context.Bookmarks.Add(bookmark);
                        context.SaveChanges();
                        Store.Bookmarks.Add(bookmark);
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
                errorProvider2.Clear();
            }
            return validate;
        }

        private void Form5_Shown(object sender, EventArgs e)
        {
            if (Bookmark != null)
            {
                Text = "Редактирование закладки (сайта)";
                button1.Text = "Сохранить";
                textBox1.Text = Bookmark.Name;
                textBox2.Text = Bookmark.Url;
            }
        }
    }
}
