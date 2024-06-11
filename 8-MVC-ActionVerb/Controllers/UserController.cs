using Microsoft.AspNetCore.Mvc;

namespace _8_MVC_ActionVerb.Controllers
{
    public class UserController : Controller
    {
        // Action Verb: Gelen isteğin türüne göre yönlendirme işlemi gerçekleştirmek istediğimiz zaman kullanılan atribute'dur.
        // Get (Okumak için) ve Post (Yazmak için)

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string userName, string userEmail, string userPass)
        {
            return Content($"User Name: {userName} Email: {userEmail} Pass: {userPass}");
        }
    }
}
