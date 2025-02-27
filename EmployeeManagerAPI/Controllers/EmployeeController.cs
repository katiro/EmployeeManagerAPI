using EmployeeManagerAPI.Model.Entity;
using EmployeeManagerAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagerAPI.Controllers
{
    [Route("api/empleados")]
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
        public List<Empleado> GetEmployees()
        {
            return _employeeService.GetEmployees();
        }

        [HttpGet("{id}")]
        [Authorize]
        public Empleado GetEmployee(int id)
        {
            return _employeeService.GetEmployee(id);
        }


        [HttpPost]
        [Authorize]
        public Empleado AddEmployee([FromBody] Empleado employee)
        {
            return _employeeService.AddEmployee(employee);
        }


        [HttpPut("{id}")]
        [Authorize]
        public Empleado UpdateEmployee([FromBody] Empleado employee,int id)
        {
            employee.Id = id;
            return _employeeService.UpdateEmployee(employee);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public void DeleteEmployee(int id)
        {
            _employeeService.DeleteEmployee(id);
        }
    }
}