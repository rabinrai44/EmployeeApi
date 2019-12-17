using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
        Employee GetEmployeeById(int employeeId);
    }
}
