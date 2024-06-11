using Microsoft.AspNetCore.Mvc;

namespace _7_MVC_FirstApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //...
            return View();
            //return Content("Merhaba MVC Dünyası - First Controller");
        }

        public IActionResult Blog()
        {


            return View();
        }


    }
}
