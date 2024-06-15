using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyServer
{
    static internal class Actions
    {
        public static void InitListModules()
        {
            // Получаем список всех модулей в бд
            using var context = new Configs.DataBase();
            var modules = context.Modules.Include(m => m.Configs);
            foreach (var module in modules)
            {
                Store.Modules.Add(module);
            }
        }

        public static void InitListPrograms()
        {
            // Получаем список всех программ
            using var context = new Configs.DataBase();
            var programs = context.Programs;
            foreach (var program in programs)
            {
                Store.Programs.Add(program);
            }
        }

        public static void InitListBookmarks()
        {
            // Получаем список всех программ
            using var context = new Configs.DataBase();
            var bookmarks = context.Bookmarks;
            foreach (var bookmark in bookmarks)
            {
                Store.Bookmarks.Add(bookmark);
            }
        }
    }
}
