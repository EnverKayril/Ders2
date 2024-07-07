using _12_MVC_ActionFilter.Filters;
using _12_MVC_ActionFilter.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _12_MVC_ActionFilter.Controllers
{
    [TypeFilter(typeof(LogActionFilter))]
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

        //[ActionName("Guvenlik")]
        //[Authorize(Roles = "Admin")]
        //[ResponseCache(Duration = 3600)]
        public IActionResult Privacy()
        {
            return View();
        }
        [NonAction]
        public void DenemeMetod()
        {
            //...
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
