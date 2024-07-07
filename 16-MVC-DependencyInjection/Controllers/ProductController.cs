using _16_MVC_DependencyInjection.Services.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace _16_MVC_DependencyInjection.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            _productService.Create();
            return Content("");
        }
        public IActionResult Update()
        {
            _productService.Update();
            return Content("");
        }
        public IActionResult Delete()
        {
            _productService.Delete();
            return Content("");

        }
        public IActionResult GetAllProduct()
        {
            _productService.GetAllProducts();
            return Content("");
        }
        public IActionResult GetProductById()
        {
            return Content("");
        }
        public IActionResult GetByName()
        {
            return Content("");
        }
    }
}
