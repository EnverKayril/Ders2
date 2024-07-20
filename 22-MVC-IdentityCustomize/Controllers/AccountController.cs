using _22_MVC_IdentityCustomize.Contexts;
using _22_MVC_IdentityCustomize.Models;
using _22_MVC_IdentityCustomize.Models.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _22_MVC_IdentityCustomize.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppDbContext _context;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDbContext appDbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var userInfo = new MyAccountVM
            {
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                BlogPosts = _context.BlogPosts.Where(x => x.UserId == user.Id).ToList()
            };
            return View(userInfo);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser { UserName = model.UserName, FirstName = model.FirstName, LastName = model.LastName, Email = model.Email };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model, string? ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(ReturnUrl))
                    {
                        return RedirectToAction(ReturnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult PostEdit(int id)
        {
            return Content("Post Güncelleme: Id: " + id);
        }

        [HttpPost]
        public IActionResult Edit(MyAccountVM model)
        {
            return Content($"Adı: {model.FirstName} Soyadı: {model.LastName}");
        }
    }
}
