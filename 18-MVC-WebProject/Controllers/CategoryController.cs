using _18_MVC_WebProject.Contexts;
using _18_MVC_WebProject.Models;
using _18_MVC_WebProject.Models.Enums;
using _18_MVC_WebProject.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace _18_MVC_WebProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Categories
                .Select(c => new CategoryListVM
                {
                    Id = c.Id,
                    Name = c.Name,
                    CreateDate = c.CreatedDate,
                    Status = c.Status
                }).ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryCreateVM model)
        {
            if (ModelState.IsValid)
            {
                var cat = new Category() { Name = model.Name };
                _context.Categories.Add(cat);
                var result = _context.SaveChanges();
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return Content("Ekleme işlemi sırasında bir hata gerçekleşti");
                }
            }
            else
                return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var cat = _context.Categories.Find(id);
            if (cat != null)
            {
                var catVM = new CategoryCreateVM { Name = cat.Name };
                return View(catVM);
            }
            else
                return Content("Güncelleme işlemi sırasında bir hata gerçekleşti.");
        }

        [HttpPost]
        public IActionResult Edit(CategoryCreateVM model, int id)
        {
            var cat = _context.Categories.Find(id);
            cat.Name = model.Name;
            cat.UpdatedDate = DateTime.Now;
            cat.Status = Status.Updated;

            _context.Categories.Update(cat);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var cat = _context.Categories.Find(id);
            cat.Status = Status.Deleted;
            cat.DeletedDate = DateTime.Now;

            _context.Categories.Update(cat);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult EditStatus(int id)
        {
            var cat = _context.Categories.Find(id);
            if (cat != null)
            {
                if (cat.Status == Status.Created || cat.Status == Status.Updated)
                {
                    cat.Status = Status.Deleted;
                }
                else
                {
                    cat.Status = Status.Created;
                }
                _context.Update(cat);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return Content("Beklenmeyen bir hata gerçekleşti.");
            }
        }
    }
}