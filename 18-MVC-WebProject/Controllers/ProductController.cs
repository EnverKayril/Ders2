using _18_MVC_WebProject.Contexts;
using _18_MVC_WebProject.Models;
using _18_MVC_WebProject.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _18_MVC_WebProject.Controllers
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
            // Loading Type 1-Eager, 2-Lazy, 3-Explict Loading
            var products = _context.Products.Include(x => x.Category).Select(x => new ProductListVM { Id = x.Id, Name = x.Name, Price = x.Price, Stock = x.Stock, CreatedDate = x.CreatedDate, Status = x.Status, Image = x.Image, CategoryId = x.Category.Id, CategoryName = x.Category.Name }).ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ProductCreateVM createVM = new ProductCreateVM();
            createVM.Categories = _context.Categories.ToList();
            return View(createVM);
        }

        [HttpPost]
        public IActionResult Create(ProductCreateVM model, IFormCollection form)
        {
            var photo = form.Files["Image"];
            var fileName = "";
            if (photo != null && photo.Length > 0)
            {
                fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(photo.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/products", fileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    photo.CopyTo(stream);
                }
            }

            model.Product.Image = fileName;
            _context.Products.Add(model.Product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id, string name)
        {
            var result = _context.ProductDetails.Any(x => x.Id == id);
            if (!result)
            {
                ProductDetailVM detailVM = new ProductDetailVM();
                detailVM.Id = id;
                detailVM.Name = name;
                return View(detailVM);
            }
            else
            {
                var detail = _context.ProductDetails.Find(id);
                ProductDetailVM detailVM = new ProductDetailVM();
                detailVM.Id = id;
                detailVM.Name = name;
                detailVM.ProductDetail = detail;
                return View(detailVM);
            }
        }

        [HttpPost]
        public IActionResult DetailsCreate(ProductDetailVM model)
        {
            var productDetail = new ProductDetail()
            {
                Id = model.Id,
                Color = model.ProductDetail.Color,
                Height = model.ProductDetail.Height,
                Width = model.ProductDetail.Width,
                Detail = model.ProductDetail.Detail
            };
            _context.ProductDetails.Add(productDetail);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DetailsEdit(ProductDetailVM model)
        {
            var productDetail = new ProductDetail()
            {
                Id = model.Id,
                Color = model.ProductDetail.Color,
                Height = model.ProductDetail.Height,
                Width = model.ProductDetail.Width,
                Detail = model.ProductDetail.Detail
            };
            _context.ProductDetails.Update(productDetail);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }

}

