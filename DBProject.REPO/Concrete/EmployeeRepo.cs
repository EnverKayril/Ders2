using DBProject.CORE;
using DBProject.REPO.Contexts;
using DBProject.REPO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject.REPO.Concrete
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public readonly AppDbContext _context;

        public EmployeeRepo(AppDbContext context)
        {
            _context = context;
        }

        public int Create(Employee employee)
        {
            _context.Employees.Add(employee);
            return _context.SaveChanges();
        }

        public int Delete(Employee employee)
        {
            _context.Employees.Remove(employee);
            return _context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public List<Employee> GetByDepartment(string department)
        {
            return _context.Employees.Where(x => x.Department == department).ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.Find(id);
        }

        public int Update(Employee employee)
        {
            _context.Employees.Update(employee);
            return _context.SaveChanges();
        }
    }
}
