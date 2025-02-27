using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using EmployeeManagerAPI.Model.Entity;

namespace EmployeeManagerAPI.Model
{
    public class EmployeeManagerDBContext : IdentityDbContext
    {
        public EmployeeManagerDBContext(DbContextOptions<EmployeeManagerDBContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

