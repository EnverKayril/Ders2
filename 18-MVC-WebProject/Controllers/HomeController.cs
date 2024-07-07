using _18_MVC_WebProject.Contexts;
using _18_MVC_WebProject.Models;
using _18_MVC_WebProject.Models.Enums;
using _18_MVC_WebProject.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _18_MVC_WebProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            CatProductListVM listVM = new CatProductListVM();
            listVM.Categories = _context.Categories.Where(x => x.Status != Status.Deleted).ToList();
            listVM.Products = _context.Products.Where(x => x.Status != Status.Deleted).ToList();
            return View(listVM);
        }

        public IActionResult GetProductWithCat(int id)
        {
            CatProductListVM listVM = new CatProductListVM();
            listVM.Categories = _context.Categories.Where(x => x.Status != Status.Deleted).ToList();
            listVM.Products = _context.Products.Where(x => x.Status != Status.Deleted && x.CategoryId == id).ToList();
            return View(listVM);
        }

        public IActionResult GetProductWithId(int id)
        {
            CatProductDetailVM listVM = new CatProductDetailVM();
            listVM.Categories = _context.Categories.Where(x => x.Status != Status.Deleted).ToList();
            listVM.Product = _context.Products.Where(x => x.Status != Status.Deleted).FirstOrDefault(x => x.Id == id);
            listVM.ProductDetail = _context.ProductDetails.FirstOrDefault(x => x.Id == id);
            return View(listVM);
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
