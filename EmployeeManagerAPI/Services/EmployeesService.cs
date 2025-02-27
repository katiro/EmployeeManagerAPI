using EmployeeManagerAPI.Model.Entity;
using EmployeeManagerAPI.Repository.Interface;

namespace EmployeeManagerAPI.Services
{
   public class EmployeesService
   {
      private readonly IEmployeesRepository _employeesRepository;

      public EmployeesService(IEmployeesRepository employeesRepository)
      {
         _employeesRepository = employeesRepository;
      }

      public List<Employee> GetEmployees()
      {
         return _employeesRepository.GetEmployees();
      }

      public Employee GetEmployee(int id)
      {
         return _employeesRepository.GetEmployee(id);
      }

      public Employee AddEmployee(Employee employee)
      {
         return _employeesRepository.AddEmployee(employee);
      }

      public Employee UpdateEmployee(Employee employee)
      {
         return _employeesRepository.UpdateEmployee(employee);
      }

      public void DeleteEmployee(int id)
      {
         _employeesRepository.DeleteEmployee(id);
      }
   }

}

