using EmployeeApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Data
{
    public class EmployeeApiContext: DbContext
    {
        public EmployeeApiContext(DbContextOptions<EmployeeApiContext> options): base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
