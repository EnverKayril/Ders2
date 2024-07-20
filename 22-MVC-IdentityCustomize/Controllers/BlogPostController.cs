using _22_MVC_IdentityCustomize.Contexts;
using _22_MVC_IdentityCustomize.Models;
using _22_MVC_IdentityCustomize.Models.VMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _22_MVC_IdentityCustomize.Controllers
{
    public class BlogPostController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public BlogPostController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            var post = new GetPostVM { Categories = _context.Categories.ToList() };
            return View(post);
        }

        [HttpPost]
        public IActionResult Create(GetPostVM model)
        {
            var post = new BlogPost
            {
                Title = model.Title,
                Content = model.Content,
                CategoryId = model.CategoryId,
                UserId = _userManager.GetUserId(User)
            };
            _context.BlogPosts.Add(post);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
