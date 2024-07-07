using _18_MVC_WebProject.Models;
using Microsoft.EntityFrameworkCore;

namespace _18_MVC_WebProject.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductDetail)
                .WithOne(pd => pd.Product)
                .HasForeignKey<ProductDetail>(pd => pd.Id);
            
            modelBuilder.Entity<Category>()
                .Property(C => C.Name)
                .IsRequired()
                .HasColumnType("nvarchar(50)");
            
            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired()
                .HasColumnType("nvarchar(50)");
            
            modelBuilder.Entity<ProductDetail>()
                .Property(pd => pd.Detail)
                .IsRequired(false)
                .HasColumnType("text");

            base.OnModelCreating(modelBuilder);
        }
    }
}
