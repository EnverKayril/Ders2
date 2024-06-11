using _6_Entity_LifeCycle_SeedData.Contexts;
using _6_Entity_LifeCycle_SeedData.Entities;
using Microsoft.EntityFrameworkCore;

namespace _6_Entity_LifeCycle_SeedData
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Track
            // Entity Select işlemlerinde döndürdüğü datayı catchleyerek takibe alır. Bunun sebebi datayı SaveChanges() yaptığımız anda datadaki değişikliği yansıtması. Ama bu izleme mekanizması bir yavaşlığa sebebiyet verir.

            AppDbContext context = new AppDbContext();

            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            var books = context.Books.ToList();

            var authors1 = context.Authors.AsNoTracking().ToList();
            var authors2 = context.Authors.ToList();


            foreach (var auth in authors1)
            {
                Console.WriteLine(context.Entry(auth).State);
            }

            Console.WriteLine("----");
            foreach (var auth in authors2)
            {
                Console.WriteLine(context.Entry(auth).State);
            }


            #endregion

            #region LifeCycle
            /*
            Entity LifeCycle: Bir entity oluşturulduğu, eklendiği, silindiği vb. işlemlerin takibini sağlar.
            Bu duruma entity state denir.

            Added: Entity eklendi olarak işaretlenir.
            Deleted: Entity silindi olarak işaretlenir.
            Modified: Entity güncellendi olarak işaretlenir.
            Unchanged: Entity değişikli olmadı.
            Detached: Entity track edilmedi (izlenmiyor).
             */


            //AppDbContext context = new AppDbContext();

            //--->> Detached
            //var author = new Author { FirstName = "Peyami", LastName = "Sefa" };
            //Console.WriteLine(context.Entry(author).State);


            //--->> Added
            //context.Authors.Add(author);
            //Console.WriteLine(context.Entry(author).State);

            //context.Entry(author).State = EntityState.Added;
            //context.SaveChanges();


            //---> Unchanged
            //var getAuthor1 = context.Authors.First(a => a.FirstName == "Peyami");
            //Console.WriteLine(context.Entry(getAuthor1).State);


            //---> Modified
            //getAuthor1.FirstName = "Piyi";
            //getAuthor1.LastName = "Mi";
            //Console.WriteLine(context.Entry(getAuthor1).State);
            //context.SaveChanges();


            //--- Deleted
            //var getAuthor2 = context.Authors.First(a => a.FirstName == "Piyi");
            //Console.WriteLine(context.Entry(getAuthor2).State);

            //context.Entry(getAuthor2).State = EntityState.Deleted;
            //Console.WriteLine(context.Entry(getAuthor2).State);
            //context.SaveChanges();


            //var author3 = context.Authors.FirstOrDefault(x => x.FirstName == "William");
            //Console.WriteLine(context.Entry(author3).State); //--> Unchanged

            //var author3 = new Author { FirstName = "Enver", LastName = "Kayrıl" };

            //context.Entry(author3).State = EntityState.Added;
            //Console.WriteLine(context.Entry(author3).State);

            //context.Entry(author3).State = EntityState.Modified;
            //Console.WriteLine(context.Entry(author3).State);

            //context.Entry(author3).State = EntityState.Deleted;
            //Console.WriteLine(context.Entry(author3).State);

            //context.Entry(author3).State = EntityState.Detached;
            //Console.WriteLine(context.Entry(author3).State);

            //context.SaveChanges();

            #endregion
        }
    }
}
