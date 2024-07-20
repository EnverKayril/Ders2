using DbProject.SERVICE.DTOs;
using DBProject.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.SERVICE.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        EmployeeDTO GetDPOById(int id);
        List<EmployeeDTO> GetAllDTOByDepartment(string department);
        List<EmployeeDTO> GetAllDTOs();
        int Create(EmployeeCreate employeeCreate);
        int Update(Employee employee);
        int Delete(Employee employee);
    }
}
