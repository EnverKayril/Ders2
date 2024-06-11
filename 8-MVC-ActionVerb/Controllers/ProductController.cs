using _8_MVC_ActionVerb.Models;
using Microsoft.AspNetCore.Mvc;

namespace _8_MVC_ActionVerb.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> _products;

        public ProductController()
        {
            if (_products == null)
            _products = new List<Product>();
        }

        public IActionResult Index()
        {
            return View(_products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            _products.Add(model);
            return RedirectToAction("Index");
        }
    }
}
