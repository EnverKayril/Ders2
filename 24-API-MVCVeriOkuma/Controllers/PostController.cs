using _24_API_MVCVeriOkuma.Models;
using _24_API_MVCVeriOkuma.Services;
using Microsoft.AspNetCore.Mvc;

namespace _24_API_MVCVeriOkuma.Controllers
{
    public class PostController : Controller
    {
        private readonly ApiService _apiService;

        public PostController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            List<PostDb> posts = await _apiService.GetApiAllPostsAsync();
            if (posts == null || posts.Count ==0)
            {
                return NotFound();
            }
            return View(posts);
        }

        public async Task<IActionResult> Details(int id)
        {
            var post = await _apiService.GetApiById(id);
            return View(post);
        }
    }
}
