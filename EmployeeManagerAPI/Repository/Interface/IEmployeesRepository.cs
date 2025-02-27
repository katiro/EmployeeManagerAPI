using EmployeeManagerAPI.Model.Entity;

namespace EmployeeManagerAPI.Repository.Interface
{
    public interface IEmployeesRepository
    {
        List<Empleado> GetEmployees();
        Empleado GetEmployee(int id);
        Empleado AddEmployee(Empleado employee);
        Empleado UpdateEmployee(Empleado employee);
        void DeleteEmployee(int id);
    }
    
}