﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _6_Entity_LifeCycle_SeedData.Contexts;

#nullable disable

namespace _6_Entity_LifeCycle_SeedData.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_6_Entity_LifeCycle_SeedData.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "William",
                            LastName = "Shakespeare"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Fyodor",
                            LastName = "Dostoyevski"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Namık",
                            LastName = "Kemal"
                        });
                });

            modelBuilder.Entity("_6_Entity_LifeCycle_SeedData.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 2,
                            Title = "Suç ve Ceza"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Title = "Kumarbaz"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            Title = "Karamazov Kardeşler"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            Title = "Yeraltından Notlar"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 3,
                            Title = "Huzur"
                        });
                });

            modelBuilder.Entity("_6_Entity_LifeCycle_SeedData.Entities.Book", b =>
                {
                    b.HasOne("_6_Entity_LifeCycle_SeedData.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("_6_Entity_LifeCycle_SeedData.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
