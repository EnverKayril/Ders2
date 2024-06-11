using _6_Entity_LifeCycle_SeedData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _6_Entity_LifeCycle_SeedData.SeedData
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Title).IsRequired().HasColumnType("nvarchar(50)");

            builder.HasData(
                new Book { Id = 1, Title = "Suç ve Ceza", AuthorId = 2 },
                new Book { Id = 2, Title = "Kumarbaz", AuthorId = 2 },
                new Book { Id = 3, Title = "Karamazov Kardeşler", AuthorId = 2 },
                new Book { Id = 4, Title = "Yeraltından Notlar", AuthorId = 2 },
                new Book { Id = 5, Title = "Huzur", AuthorId = 3 });

        }
    }
}
