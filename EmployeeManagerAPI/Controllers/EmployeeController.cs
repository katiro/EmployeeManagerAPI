using EmployeeManagerAPI.Model.Entity;
using EmployeeManagerAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeesService _employeeService;

        public EmployeeController(EmployeesService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Authorize]
        public List<Employee> GetEmployees()
        {
            return _employeeService.GetEmployees();
        }

        [HttpGet("{id}")]
        [Authorize]
        public Employee GetEmployee(int id)
        {
            return _employeeService.GetEmployee(id);
        }


        [HttpPost("add")]
        [Authorize]
        public Employee AddEmployee([FromBody] Employee employee)
        {
            return _employeeService.AddEmployee(employee);
        }


        [HttpPut("update")]
        [Authorize]
        public Employee UpdateEmployee([FromBody] Employee employee)
        {
            return _employeeService.UpdateEmployee(employee);
        }

        [HttpDelete("delete/{id}")]
        [Authorize]
        public void DeleteEmployee(int id)
        {
            _employeeService.DeleteEmployee(id);
        }
    }
}