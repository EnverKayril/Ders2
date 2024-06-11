using _3_Entity_CodeFirstLab.Contexts;
using _3_Entity_CodeFirstLab.Entities;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace _3_Entity_CodeFirstLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (AppDbContext appDbContext = new AppDbContext())
            {
                #region Create
                // Category Ekleme
                //appDbContext.Categories.Add(new Category { Name = "Kırtasiye" });
                //Category category1 = new Category() { Name = "Teknoloji" };
                //appDbContext.Categories.Add(category1);

                //Product Ekleme
                //Product product1 = new Product() { Name = "Kalem-1", Price = 19.90, Stock = 50, CreateDate = DateTime.Now, CategoryId = 1 };
                //appDbContext.Products.Add(product1);

                //var cat = appDbContext.Categories.FirstOrDefault(x => x.Name == "Kırtasiye");
                //Product product2 = new Product() { Name = "Kalem2", Price = 24.50, Stock = 100, CreateDate = DateTime.Now, CategoryId = 1 };
                //appDbContext.Products.Add(product2);

                //Product product3 = new Product() { Name = "Elma", Price = 10, Stock =1000 , CreateDate = DateTime.Now, Category = new Category() { Name = "Meyve Sebze" }, CategoryId = 3 };
                //appDbContext.Add(product3 );

                //List<Product> products = new List<Product>();
                //products.Add(new Product() { Name = "BMW", Price = 15000, Stock=20, CreateDate = DateTime.Now });
                //products.Add(new Product() { Name = "TOGG", Price = 12000, Stock=30, CreateDate = DateTime.Now });
                //products.Add(new Product() { Name = "Mercedes", Price = 14000, Stock=10, CreateDate = DateTime.Now });
                //products.Add(new Product() { Name = "KIA", Price = 11000, Stock=40, CreateDate = DateTime.Now });
                //var categoryAraba = new Category() { Name = "Arabalar",Products = products };
                //appDbContext.Add(categoryAraba);

                #endregion

                #region Delete
                //var catAraba = appDbContext.Categories.Find(4);
                //appDbContext.Categories.Remove(catAraba);


                #endregion

                #region Update

                //var productElma = appDbContext.Products.FirstOrDefault(x => x.Id == 3);
                //productElma.Name = "Armut";
                //appDbContext.Products.Update(productElma);

                #endregion




                appDbContext.SaveChanges();

            }



        }
    }
}
