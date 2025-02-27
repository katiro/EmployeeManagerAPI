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

      public List<Empleado> GetEmployees()
      {
         return _employeesRepository.GetEmployees();
      }

      public Empleado GetEmployee(int id)
      {
         return _employeesRepository.GetEmployee(id);
      }

      public Empleado AddEmployee(Empleado employee)
      {
         return _employeesRepository.AddEmployee(employee);
      }

      public Empleado UpdateEmployee(Empleado employee)
      {
         return _employeesRepository.UpdateEmployee(employee);
      }

      public void DeleteEmployee(int id)
      {
         _employeesRepository.DeleteEmployee(id);
      }
   }

}

