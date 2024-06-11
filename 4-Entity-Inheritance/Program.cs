using _4_Entity_Inheritance.Contexts;
using _4_Entity_Inheritance.Entities;

namespace _4_Entity_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var _context = new AppDbContext())
            {
                //_context.MyProperty.Add(new Employee() { BirthDate = DateTime.Now, Name = "Enver", Salary= 45000, title= "Mühendis" });
                //_context.MyProperty.Add(new Customer() { BirthDate = DateTime.Now, Name = "Yasin", OrderCount = 100, TotalVisit = 50 });

                //_context.Employees.Add(new Employee { BirthDate = DateTime.Now, Name = "Fatih", Salary = 55000, title = "Mühendis" });

                //_context.Add(new Customer() { BirthDate = DateTime.Now, Name = "Berkay", OrderCount = 200, TotalVisit = 30 });

                //_context.SaveChanges();

                var result1 = _context.Employees.ToList();
                foreach (var item in result1)
                {
                    Console.WriteLine(item.Id + " " + item.Name + " " + item.title + " " + item.Salary );
                }

                var result2 = _context.Customers.ToList();
                foreach (var item in result2)
                {
                    Console.WriteLine(item.Id + " " + item.Name + " " + item.TotalVisit + " " + item.OrderCount);
                }

                Console.WriteLine("---");
                var result3 = _context.MyProperty.ToList();
                foreach (var item in result3)
                {
                    if (item.GetType() == typeof(Customer))
                    {
                        var item2 = item as Customer;
                        Console.WriteLine(item2.Id + " " + item2.Name + " " + item2.TotalVisit + " " + item2.OrderCount);
                    }
                    else if (item is Employee)
                    {
                        var item3 = (Employee)item;
                        Console.WriteLine(item3.Id + " " + item3.Name + " " + item3.title + " " + item3.Salary + item3.GetType().ToString());
                    }
                }
            }
        }
    }
}
