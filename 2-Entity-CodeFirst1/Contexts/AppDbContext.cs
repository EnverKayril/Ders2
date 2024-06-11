using _2_Entity_CodeFirst1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Entity_CodeFirst1.Contexts
{
    // DBContext: Verilerde nesneler olarak etkileşim kurmaktan sorumlu olan birincil sınıftır. .NET Framework'ün bir parçası olarak gelmez NuGet Package aracılığıyla yüklenir.
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = ENVER\\SQLEXPRESS; Database = BookStore1; Trusted_Connection = True; TrustServerCertificate = True;");
        }




    }
}
