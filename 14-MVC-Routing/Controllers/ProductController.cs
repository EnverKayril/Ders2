using Microsoft.AspNetCore.Mvc;

namespace _14_MVC_Routing.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Details(int ProductId) 
        {
            return Content("Product Detay Id: #" + ProductId );
        }

    }
}
