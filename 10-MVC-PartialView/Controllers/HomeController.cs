using _10_MVC_PartialView.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _10_MVC_PartialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1, Name= "Kalem", Price=55},
                new Product{Id=2, Name= "Silgi", Price=25},
                new Product{Id=3, Name= "Not Defteri", Price=35},
                new Product{Id=4, Name= "Defter", Price=48},
                new Product{Id=5, Name= "Kitap", Price=67},
                new Product{Id=6, Name= "Kalem-2", Price=38}
            };

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
