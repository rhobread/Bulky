using Microsoft.AspNetCore.Mvc;

namespace BulkyWebTest.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
