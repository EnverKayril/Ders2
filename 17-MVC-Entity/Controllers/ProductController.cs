using _17_MVC_Entity.Contexts;
using _17_MVC_Entity.Models;
using _17_MVC_Entity.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace _17_MVC_Entity.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Products.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateProductVM model)
        {
            var product = new Product() { Name = model.Name, Price = model.Price };
            _context.Products.Add(product);
            var result = _context.SaveChanges();

            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            else
                return BadRequest();
        }
    }
}
