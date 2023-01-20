using Microsoft.AspNetCore.Mvc;

namespace Deneme2_AspNetCore.Models
{
    public class Product : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
