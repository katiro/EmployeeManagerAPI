using EmployeeManagerAPI.Model.Entity;

namespace EmployeeManagerAPI.Repository.Interface
{
    public interface IEmployeesRepository
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
    }
    
}