using Microsoft.AspNetCore.Mvc;

namespace MvcProje.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
