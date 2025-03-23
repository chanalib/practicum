using MagicalMusic.CORE.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure; // הוספת הפניה

namespace MagicalMusic.DATA
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; } // שונה ל-Users
        public DbSet<Song> Songs { get; set; } // שונה ל-Songs
        public DbSet<Creator> Creators { get; set; } // שונה ל-Creators

        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySql("Server=localhost;Database=magical_music_db;User Id=root;Password=Cc32811619;charset=utf8mb4;",
                    new MySqlServerVersion(new Version(8, 0, 0))); // ודא שאתה מציין את גרסת ה-MySQL שלך
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Songs)
                .WithMany(s => s.Users)
                .UsingEntity(j => j.ToTable("user_song")); // השתמש בטבלה הקיימת
        }
    }
}
