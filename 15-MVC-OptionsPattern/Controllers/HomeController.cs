using _15_MVC_OptionsPattern.Models;
using _15_MVC_OptionsPattern.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace _15_MVC_OptionsPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        private readonly AppSettings _appSettings;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, IOptions<AppSettings> appSettings)
        {
            _logger = logger;
            _configuration = configuration;
            _appSettings = appSettings.Value;
        }

        public IActionResult Index()
        {
            string key = _appSettings.AppKey;
            int value = _appSettings.AppValue;
            return Content($"Options Key: {key} - Value: {value}");
            //return Content("Title: " + _configuration.GetValue<string>("WebTitle"));
            //return View();
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
