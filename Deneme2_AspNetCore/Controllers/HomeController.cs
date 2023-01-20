using Microsoft.AspNetCore.Mvc;

namespace Deneme2_AspNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
