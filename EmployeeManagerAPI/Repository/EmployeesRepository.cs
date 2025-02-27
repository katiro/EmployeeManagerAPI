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

        public List<Empleado> GetEmployees()
        {
            return _context.Empleado.ToList();
        }

        public Empleado GetEmployee(int id)
        {
            return _context.Empleado.FirstOrDefault(e => e.Id == id);
        }

        public Empleado AddEmployee(Empleado employee)
        {
            _context.Empleado.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Empleado UpdateEmployee(Empleado employee)
        {
            _context.Empleado.Update(employee);
            _context.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            var employee = _context.Empleado.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _context.Empleado.Remove(employee);
                _context.SaveChanges();
            }
        }
    }
}