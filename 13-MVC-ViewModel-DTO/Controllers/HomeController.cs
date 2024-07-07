using _13_MVC_ViewModel_DTO.Models;
using _13_MVC_ViewModel_DTO.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _13_MVC_ViewModel_DTO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer mode)
        {
            if (string.IsNullOrEmpty(mode.CustomerName))
            {
                ModelState.AddModelError("CustomerName", "Müşteri alanı zorunludur");
            }
            if (string.IsNullOrEmpty(mode.CustomerEmail) || !mode.CustomerEmail.Contains('@'))
            {
                ModelState.AddModelError("CustomerEmail", "Geçerli bir e-posta adresi giriniz");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }

            return View(mode);
        }

        [HttpGet]
        public IActionResult Product()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Product(ProductVM model)
        {
            if (ModelState.IsValid)
            {
                return Content("İşlem Başarılı");
            }
            return View(model);
        }

        public IActionResult Index()
        {
            return View();
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
