
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagerAPI.Model.Entity
{

    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string WorkStation { get; set; }
        public required string Departament { get; set; }
    }

}