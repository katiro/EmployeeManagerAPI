using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EmployeeManagerAPI.Model
{
    public class EmployeeManagerDBContext : IdentityDbContext
    {
        public EmployeeManagerDBContext(DbContextOptions<EmployeeManagerDBContext> options) : base(options)
        {
        }
    }
}

