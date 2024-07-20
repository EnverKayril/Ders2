using DBProject.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject.REPO.Interfaces
{
    public interface IEmployeeRepo
    {
        List<Employee> GetAll();
        Employee GetById(int id);
        List<Employee> GetByDepartment(string department);
        int Create(Employee employee);
        int Update(Employee employee);
        int Delete(Employee employee);
    }
}
