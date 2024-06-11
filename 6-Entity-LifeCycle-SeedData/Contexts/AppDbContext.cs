using _6_Entity_LifeCycle_SeedData.Entities;
using _6_Entity_LifeCycle_SeedData.SeedData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Entity_LifeCycle_SeedData.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = ENVER\\SQLEXPRESS; Database = EntitySeed; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Data, genellikle veri tabanı ilk oluşturulduğunda, ilk verileri bir veritabanına ekleme sürecini ifade eder.

            modelBuilder.Entity<Author>().HasData(
                new Author { Id=1, FirstName= "William", LastName="Shakespeare" },
                new Author { Id=2, FirstName= "Fyodor", LastName="Dostoyevski" },
                new Author { Id=3, FirstName= "Namık", LastName="Kemal" }
                );

            // 2. Yol
            modelBuilder.ApplyConfiguration(new BookConfig());


            base.OnModelCreating(modelBuilder);
        }
    }
}
