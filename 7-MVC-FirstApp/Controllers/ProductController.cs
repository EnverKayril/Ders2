using _7_MVC_FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace _7_MVC_FirstApp.Controllers
{
    public class ProductController : Controller
    {
        /* Controller (Denetleyici): Web uygulamasının mantık kısmını temsil eder. (C# tarafı-beybi) İstek-Yönlendirme takibi.
        - Kullanıcının isteğini alır.
        - İsteği yönlendirir.
        - İstekleri İşler.
        - Eğer istek model (veritabanı) işlemiyse bize veri sağlar.
        - Kullanıcıya yanıt verir.
         */




        List<Product> products = new List<Product>()
            {
            new Product { Id = 1, Image = "https://via.placeholder.com/150", Name=  "Kalem1", Price = 140 },
            new Product { Id = 2, Image = "https://via.placeholder.com/150", Name = "Kalem2", Price = 150 },
            new Product { Id = 3, Image = "https://via.placeholder.com/150", Name = "Kalem3", Price = 160 },
            new Product { Id = 4, Image = "https://via.placeholder.com/150", Name = "Kalem4", Price = 130 },
            new Product { Id = 4, Image = "https://via.placeholder.com/150", Name = "Kalem4", Price = 110 },
            new Product { Id = 4, Image = "https://via.placeholder.com/150", Name = "Kalem4", Price = 120 }
            };

        public IActionResult Index()
        {
            return View(products);
        }

            // Kullanıcının isteklerini alıp yönetip yanıt veren özel metotlardır.

        public IActionResult Detail(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }

            // Action Results: action metotların geri dönüş değerini temsil eder.

        public IActionResult Main()
        {
            return View("Deneme");
            // ViewResutl: bir görünüm sayfasını temsil eder. (.cshtml) Kullanıcıya HTML çıktısı oluşturmak için kullanılır.
        }

        public IActionResult GetContent()
        {
            return Content("Merhaba Dünya");
            // ContentResult: Kullanıcıya bir metin veya içerik göndermek için kullanırlır.
        }

        public IActionResult RedirectToHome()
        {
            // return Redirect("../Home/blog");
            // return RedirectToAction("Index");
            return RedirectToAction("Index", "Home"); // Farklı controllerdaki action metota gitme.
        }

        public IActionResult GetData()
        {
            var userData = new { Name = "John", Age = 30 };
            return Json(userData);
        }

        //public IActionResult DownloadFile()
        //{
        //    return File();
        //}

        public IActionResult MyAction()
        {
            return BadRequest();
        }



    }
}
