using DBProject.CORE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject.REPO.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ENVER\\SQLEXPRESS01; Database=DbProject;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
