using CrudMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrudMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}