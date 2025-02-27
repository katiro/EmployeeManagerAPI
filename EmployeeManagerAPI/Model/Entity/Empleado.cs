namespace EmployeeManagerAPI.Model.Entity
{
    public class Empleado
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string Email { get; set; }
        public required string Telefono { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}