using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // GET: api/employees
        [HttpGet]
        public ActionResult<List<Employee>> GetEmployees()
        {
            return Ok(_employeeRepository.GetAllEmployees().ToList());
        }

        // GET: api/employees/id
        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound("User not found");
            }

            return Ok(employee);
        }

        // POST: api/employees
        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _employeeRepository.Add(employee);

            return NoContent();
        }

        // PUT: api/employees/id
        [HttpPut("{id}")]
        public ActionResult UpdateEmployee(int id, Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != employee.Id)
                return BadRequest();

            _employeeRepository.Update(employee);

            return NoContent();
        }

        // DELETE: api/employees/id
        [HttpDelete("{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employee = _employeeRepository.GetEmployeeById(id);

            if (employee == null)
                return NotFound();

            _employeeRepository.Delete(employee);

            return Ok(employee);
        }
    }
}