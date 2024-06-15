
using MyServer.Configs;
using System.Text.RegularExpressions;

namespace MyServer
{   
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (args.Contains("--initialize-db")) {
                CreateTable();
            }
            if (args.Contains("--initialize-configs"))
            {
                InitConfigFiles();
            }
            Actions.InitListModules();
            Actions.InitListPrograms();
            Actions.InitListBookmarks();
            Actions.InitListDomains();
            Application.Run(new Form1());
        }
        static void CreateTable()
        {
            using var context = new DataBase();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        private static void InitConfigFiles()
        {
            ReplaceMyServerDir("userdata/config/MySQL-8.4.ini");
            ReplaceMyServerDir("userdata/config/Apache_2.4-PHP_8.3/vhost.conf");
            ReplaceMyServerDir("userdata/config/Apache_2.4-PHP_8.3/server.conf");
        }

        private static void ReplaceMyServerDir(string filepath)
        {
            if (File.Exists(filepath))
            {
                StreamReader reader = new(filepath);
                string content = reader.ReadToEnd();
                reader.Close();

                content = content.Replace("%myserverdir%", Directory.GetCurrentDirectory());

                StreamWriter writer = new(filepath);
                writer.Write(content);
                writer.Close();
            }
        }
    }
}