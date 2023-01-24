using e_commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
        public DbSet<Product> Products { get; set; }
    }
}
