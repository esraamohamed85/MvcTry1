using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL.DB;

namespace WebApplication1.Controllers
{
    public class DepartmentController : Controller
    {
        ApplicationDbContext Db = new ApplicationDbContext();
        public IActionResult Index()

        {
            var result = Db.Departments.ToList();
            return View(result);
        }
    }
}
