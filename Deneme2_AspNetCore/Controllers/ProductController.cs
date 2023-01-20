using Microsoft.AspNetCore.Mvc;

namespace Deneme2_AspNetCore.Controllers
{
    public class ProductController : Controller //controller kısım
    {
        ProductController product = new ProductController(); //model kısım
        public IActionResult GetProducts()
        {
            return View(); //view kısım
        }
    }
}
