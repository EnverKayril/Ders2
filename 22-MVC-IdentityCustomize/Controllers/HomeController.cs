using _22_MVC_IdentityCustomize.Contexts;
using _22_MVC_IdentityCustomize.Models;
using _22_MVC_IdentityCustomize.Models.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace _22_MVC_IdentityCustomize.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(ILogger<HomeController> logger, AppDbContext context, UserManager<AppUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var mainpost = await _context.BlogPosts
               .Include(bp => bp.User)
               .Where(bp => bp.IsPublished)
               .OrderByDescending(bp => bp.PublishedDate)
               .Select(X => new GetMainPostVM { PostId = X.Id, Title = X.Title, Content = X.Content, PublishDate = X.PublishedDate, UserName = X.User.UserName }).ToListAsync();

            return View(mainpost);
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
