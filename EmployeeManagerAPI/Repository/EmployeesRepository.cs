using EmployeeManagerAPI.Model;
using EmployeeManagerAPI.Model.Entity;
using EmployeeManagerAPI.Repository.Interface;

namespace EmployeeManagerAPI.Repository
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly EmployeeManagerDBContext _context;

        public EmployeesRepository(EmployeeManagerDBContext context)
        {
            _context = context;
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }
    }
}