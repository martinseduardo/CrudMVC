using CrudMVC.Models;
using CrudMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrudMVC.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public void AddEmployee(string name,
            string email,
            string login,
            string password)
        {
            var employee = new Employee()
            {
                Name = name,
                Email = email,
                Login = login,
                Password = password
            };
            _employeeService.Create(employee);
        }

        [HttpPut("")]
        public void UpdateEmployee(Employee employee)
        {
            _employeeService.Update(employee);
        }

        [HttpGet("/{id}")]
        public Employee GetEmployee(string id)
        {
            return _employeeService.Find(id);
        }

        [HttpDelete("/{id}")]
        public void DeleteEmployee(string id)
        {
            _employeeService.Delete(id);
        }
    }
}