using _3_Entity_CodeFirstLab.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Entity_CodeFirstLab.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);
            optionsBuilder.UseSqlServer("Server = ENVER\\SQLEXPRESS; Database = Products; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        public override int SaveChanges()
        {
            var result = base.SaveChanges();
            if (result > 0)
            {
                Console.WriteLine("İşlem başarılı. Yapılan işlem sayısı: "+ result);
                return result;
            }
            else
            {
                Console.WriteLine("İşlem başarısız.");
                return result;
            }
        }

    }
}
