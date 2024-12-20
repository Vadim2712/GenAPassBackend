using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

namespace GenAPassBackend.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<UserService> UserServices { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Settings> Settings { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public ApplicationDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Убедитесь, что строка подключения соответствует вашему SQL Server
            optionsBuilder.UseSqlServer("Server=Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=trueLAPTOP-QFDTPVLV;Database=your_database;User Id=your_username;Password=your_password;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<UserService>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

