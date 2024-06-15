using Microsoft.EntityFrameworkCore;
using MyServer.Model;

namespace MyServer.Configs
{
    internal class DataBase: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MyDatabase.db");
        }

        public DbSet<Module> Modules { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<MyProgram> Programs { get; set; }
        public DbSet<Bookmark> Bookmarks { get; set; }
        public DbSet<Domains> Domains { get; set; }
    }
}
