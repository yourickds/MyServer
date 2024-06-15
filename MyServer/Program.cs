
using MyServer.Configs;

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
            Actions.InitListModules();
            Actions.InitListPrograms();
            Actions.InitListBookmarks();
            Application.Run(new Form1());
        }
        static void CreateTable()
        {
            using var context = new DataBase();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}