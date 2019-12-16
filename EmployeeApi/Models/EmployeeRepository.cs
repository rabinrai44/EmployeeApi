using EmployeeApi.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeApiContext _context;

        public EmployeeRepository(EmployeeApiContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAllEmployees() 
        { 
            return _context.Employees;
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            _context.Remove(employee);
            _context.SaveChanges();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _context.Employees.Find(employeeId);
        }

        public void Update(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
