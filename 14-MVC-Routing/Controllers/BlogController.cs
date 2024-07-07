using Microsoft.AspNetCore.Mvc;

namespace _14_MVC_Routing.Controllers
{
    public class BlogController : Controller
    {
        [Route("anasayfa")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
