using Microsoft.AspNetCore.Mvc;

namespace BulkyMVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
