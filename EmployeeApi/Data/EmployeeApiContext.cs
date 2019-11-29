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

        // Seed Initial Employee Data
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().HasData(
        //        new Employee
        //        {
        //            Id = 1,
        //            FirstName = "Mark",
        //            LastName = "Kall",
        //            Position = "Developer",
        //            Salary = 80000.0
        //        },

        //        new Employee
        //        {
        //            Id = 2,
        //            FirstName = "Jason",
        //            LastName = "Rai",
        //            Position = "Assistant",
        //            Salary = 20000.0
        //        }
        //    );
        //}
    }
}
