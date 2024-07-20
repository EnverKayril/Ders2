using DbProject.SERVICE.DTOs;
using DbProject.SERVICE.Interfaces;
using DBProject.CORE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBProject.UIApi.Controllers
{
    [Route("api/[controller]s/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public HomeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var emps = _service.GetAll();
            if (emps.Count > 0)
                return Ok(emps);
            return BadRequest();
        }

        [HttpGet]
        public IList<EmployeeDTO> GetAllEmployeesFullName()
        {
            return _service.GetAllDTOs();
        }

        [HttpGet]
        public IActionResult GetEmployeeById(int id)
        {
            var emp = _service.GetDPOById(id);
            return Ok(emp);
        }

        [HttpGet("{department}")]
        public IActionResult GetEmployeeByDepartment(string department)
        {
            var emps = _service.GetAllDTOByDepartment(department);
            return Ok(emps);
        }

        [HttpPost]
        public IActionResult CreateEmployee([FromBody] EmployeeCreate employee)
        {
            var result = _service.Create(employee);
            if (result>0)
                return Ok(result);
            return BadRequest();
        }

        [HttpPut]
        public IActionResult UpdateEmployee([FromBody] Employee employee)
        {
            var result = _service.Update(employee);
            if(result > 0)
                return Ok(result);
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult DeleteEmployee([FromBody] Employee employee)
        {
            var result = _service.Delete(employee);
            if(result > 0)
                return Ok();
            return BadRequest();
        }
    }
}
