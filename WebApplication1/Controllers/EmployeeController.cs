using Microsoft.AspNetCore.Mvc;
using WebApplication1.data;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        AppDbContext Context = new AppDbContext();
        public IActionResult Index()
        {
            var Employees = Context.employees.ToList();


            return View("Index", Employees);
        }
    }
}
