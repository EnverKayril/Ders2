using _5_Entity_DataAnnotationFluentApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Entity_DataAnnotationFluentApi.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = ENVER\\SQLEXPRESS; Database = EntityDataFluent; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        // Fluent Api Kavramının uygulandığı yer.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // PrimaryKey
            modelBuilder.Entity<Book>().HasKey(b => b.Id); 

            // Not Null
            modelBuilder.Entity<Book>()
                        .Property(b => b.Title)
                        .IsRequired(true)
                        .HasMaxLength(50);

            modelBuilder.Entity<Book>()
                        .Property(b => b.Description)
                        .HasColumnName("Açıklama")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnOrder(3);

            modelBuilder.Entity<Book>()
                        .HasCheckConstraint("CK_Book_Stock" , "Stock >= 0")
                        .Property(b => b.Stock)
                        .HasDefaultValue(0);

            modelBuilder.Entity<Book>()
                        .ToTable("TblBook");


            modelBuilder.Entity<Author>()
                        .Ignore(c => c.FullName);

            // One to Many
            modelBuilder.Entity<Book>()
                        .HasOne(b => b.Author)
                        .WithMany(c => c.Book)
                        .HasForeignKey(a => a.AuthorId);

            // One to One
            modelBuilder.Entity<Book>()
                        .HasOne(b => b.BookDetail)
                        .WithOne(c => c.Book)
                        .HasForeignKey<BookDetail>(b => b.BookId);


            base.OnModelCreating(modelBuilder);
        }

    }
}
