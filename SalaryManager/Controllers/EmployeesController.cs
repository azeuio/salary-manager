using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalaryManager.Data;
using SalaryManager.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryManager.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly SalaryContext _context;

        public EmployeesController(SalaryContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index(string sortOrder = "name")
        {
            var employees = _context.Employees.AsQueryable();

            employees = sortOrder switch
            {
                "salary" => employees.OrderByDescending(e => e.BaseSalary),
                "department" => employees.OrderBy(e => e.Department),
                _ => employees.OrderBy(e => e.FirstName)
            };

            return View(await employees.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Email,Department,BaseSalary,BonusPercentage")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee.CreatedDate = DateTime.UtcNow;
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,Department,BaseSalary,BonusPercentage")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Fetch the existing employee to preserve CreatedDate
                    var existingEmployee = await _context.Employees.FindAsync(id);
                    if (existingEmployee == null)
                    {
                        return NotFound();
                    }

                    // Update only the editable fields
                    existingEmployee.FirstName = employee.FirstName;
                    existingEmployee.LastName = employee.LastName;
                    existingEmployee.Email = employee.Email;
                    existingEmployee.Department = employee.Department;
                    existingEmployee.BaseSalary = employee.BaseSalary;
                    existingEmployee.BonusPercentage = employee.BonusPercentage;
                    existingEmployee.UpdatedDate = DateTime.UtcNow;

                    _context.Update(existingEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details), new { id = employee.Id });
            }
            
            // Log validation errors for debugging
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            foreach (var error in errors)
            {
                System.Diagnostics.Debug.WriteLine($"Validation Error: {error.ErrorMessage}");
            }
            
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Employees/Analytics
        public async Task<IActionResult> Analytics()
        {
            var employees = await _context.Employees.ToListAsync();
            return View(employees);
        }

        // API endpoint for chart data
        [HttpGet]
        [Route("api/employees/salary-by-department")]
        public async Task<IActionResult> GetSalaryByDepartment()
        {
            var data = await _context.Employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    department = g.Key,
                    average = g.Average(e => e.BaseSalary),
                    count = g.Count(),
                    total = g.Sum(e => e.BaseSalary)
                })
                .ToListAsync();

            return Json(data);
        }

        // API endpoint for employee salary distribution
        [HttpGet]
        [Route("api/employees/salary-distribution")]
        public async Task<IActionResult> GetSalaryDistribution()
        {
            var employees = await _context.Employees.ToListAsync();
            var data = employees.Select(e => new
            {
                name = $"{e.FirstName} {e.LastName}",
                baseSalary = e.BaseSalary,
                totalSalary = e.GetTotalSalary(),
                department = e.Department
            }).ToList();

            return Json(data);
        }

        // API endpoint for department count
        [HttpGet]
        [Route("api/employees/department-distribution")]
        public async Task<IActionResult> GetDepartmentDistribution()
        {
            var data = await _context.Employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    department = g.Key,
                    count = g.Count()
                })
                .ToListAsync();

            return Json(data);
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
