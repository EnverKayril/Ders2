using _19_MVC_Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _19_MVC_Identity.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Book> Books { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
