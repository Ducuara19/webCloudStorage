using Microsoft.EntityFrameworkCore;
using WebCloundStorage.Shared.Entities;

namespace WebCloundStorage.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().HasIndex(c => c.UserName).IsUnique();

        }
    }

    

}
