using Microsoft.AspNetCore.Mvc;

namespace _18_MVC_WebProject.Controllers
{
    
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
