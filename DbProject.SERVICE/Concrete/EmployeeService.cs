using DbProject.SERVICE.DTOs;
using DbProject.SERVICE.Interfaces;
using DBProject.CORE;
using DBProject.REPO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.SERVICE.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepo _employeeRepo;

        public EmployeeService(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public int Create(EmployeeCreate employeeCreate)
        {
            if (employeeCreate is not null)
            {
                var employee = new Employee() { FirstName = employeeCreate.FirstName, LastName = employeeCreate.LastName, Department = employeeCreate.Department };
                try
                {
                return _employeeRepo.Create(employee);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                throw new Exception("Employee DTO Nesnesi Boş Olamaz.");
            }
        }

        public int Delete(Employee employee)
        {
            return _employeeRepo.Delete(employee);
        }

        public List<Employee> GetAll()
        {
            return _employeeRepo.GetAll();
        }

        public List<EmployeeDTO> GetAllDTOByDepartment(string department)
        {
            return _employeeRepo.GetByDepartment(department).Select(x => new EmployeeDTO { FullName = x.FirstName + " " + x.LastName }).ToList();
        }

        public List<EmployeeDTO> GetAllDTOs()
        {
            return _employeeRepo.GetAll().Select(x => new EmployeeDTO { FullName = x.FirstName + " " + x.LastName }).ToList();
        }

        public EmployeeDTO GetDPOById(int id)
        {
            var emp = _employeeRepo.GetById(id);
            return new EmployeeDTO { FullName = emp.FirstName + " " + emp.LastName };
        }

        public int Update(Employee employee)
        {
            return _employeeRepo.Update(employee);
        }
    }
}
