using Microsoft.EntityFrameworkCore;
using Recap.Models.Context.Configs;

namespace Recap.Models.Context
{
    public class MyDbContext : DbContext
    {

        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=ASPMVCDatabaseEntity;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
        }

    }
}
