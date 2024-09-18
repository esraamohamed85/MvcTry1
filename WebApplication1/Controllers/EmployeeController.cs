using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL.DB;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext Db = new ApplicationDbContext();
        public IActionResult Index()
        {
            var result = Db.Employees.ToList();
           

            return View(result);
        }
    }
}
