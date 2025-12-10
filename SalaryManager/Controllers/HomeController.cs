using Microsoft.AspNetCore.Mvc;
using SalaryManager.Data;

namespace SalaryManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly SalaryContext _context;

        public HomeController(SalaryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["EmployeeCount"] = _context.Employees.Count();
            ViewData["AvgSalary"] = _context.Employees.Any() ? _context.Employees.Average(e => e.BaseSalary) : 0;
            ViewData["TotalPayroll"] = _context.Employees.Sum(e => e.BaseSalary);
            ViewData["DepartmentCount"] = _context.Employees.Select(e => e.Department).Distinct().Count();
            return View();
        }

        [Route("404")]
        [Route("Error404")]
        public IActionResult Error404()
        {
            Response.StatusCode = 404;
            return View("~/Views/Shared/Error404.cshtml");
        }
    }
}
