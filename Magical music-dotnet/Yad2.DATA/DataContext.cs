    using MagicalMusic.CORE.Models;
    using Microsoft.EntityFrameworkCore;
    using Pomelo.EntityFrameworkCore.MySql.Infrastructure; // הוספת הפניה

    namespace MagicalMusic.DATA
    {
        public class DataContext : DbContext
        {
            public DbSet<User> Users { get; set; }
            public DbSet<Song> Songs { get; set; }
            public DbSet<Creator> Creators { get; set; }

            public DataContext(DbContextOptions<DataContext> options)
                : base(options) { }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=magical_music_db;User Id=root;Password=Cc32811619;",
                        new MySqlServerVersion(new Version(8, 0, 0))); // ודא שאתה מציין את גרסת ה-MySQL שלך
            }
        }
    }
