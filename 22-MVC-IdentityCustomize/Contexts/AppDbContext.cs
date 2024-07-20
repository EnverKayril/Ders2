using _22_MVC_IdentityCustomize.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _22_MVC_IdentityCustomize.Contexts
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(
                new Category {Id = 1,Name = "Mobil Teknoloji"},
                new Category {Id = 2,Name = "Programlama Dilleri"},
                new Category {Id = 3,Name = "Yazılım Sektörü"});

            builder.Entity<Category>().Property(x => x.Name).HasColumnType("nvarchar(50)");

            builder.Entity<Category>()
                .HasMany(x => x.BlogPosts)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);

            builder.Entity<BlogPost>()
                .HasOne(x => x.User)
                .WithMany(x => x.BlogPosts)
                .HasForeignKey(x => x.UserId);
        }


    }
}
