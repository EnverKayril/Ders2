using _4_Entity_Inheritance.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Entity_Inheritance.Contexts
{
    public class AppDbContext : DbContext
    {
        // TPT (Table Per Type)
        // Kalıtımsal mimariyi temsil eden yapı

        // TPH (Table Per Hieararchy)
        // Bu yaklaşım tüm kalıtım yapısını temsil etmek için veritabanında tablo oluşturur.

        public DbSet<BasePerson> MyProperty { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = ENVER\\SQLEXPRESS; Database = Inheritance1; Trusted_Connection = True; TrustServerCertificate = True;");
        }
    }
}
