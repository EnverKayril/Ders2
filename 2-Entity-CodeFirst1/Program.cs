using _2_Entity_CodeFirst1.Contexts;
using _2_Entity_CodeFirst1.Models;

namespace _2_Entity_CodeFirst1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TEMEL Operasyonlar CRUD
            #region Create
            //AppDbContext context = new AppDbContext();

            //Author author1 = new Author() { FirstName = "William", LastName="Shakespeare" };
            //context.Authors.Add(author1);

            //context.Add(new Author() { FirstName = "Enver", LastName = "Kayrıl" });

            //context.SaveChanges();
            #endregion

            #region Read
            //AppDbContext dbContext = new AppDbContext();
            //var Yazar = dbContext.Authors.ToList();
            //foreach (var item in Yazar)
            //{
            //    Console.WriteLine(item.FirstName + " " +item.LastName);
            //}

            //Console.WriteLine("\n-------------------------\n");

            //var Yazar2 = dbContext.Authors.Where(a => a.FirstName == "Enver").Select(a => a.FirstName);

            //foreach (var item in Yazar2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Update
            //AppDbContext context = new AppDbContext();
            //var author1 = context.Authors.Find(2);
            //author1.FirstName = "Envercan";
            //context.Authors.Update(author1);
            //context.SaveChanges();
            #endregion

            #region Remove
            AppDbContext dbContext = new AppDbContext();
            var author1 = dbContext.Authors.FirstOrDefault(x => x.Id == 2);

            dbContext.Authors.Remove(author1);
            dbContext.SaveChanges();

            #endregion


        }
    }
}
