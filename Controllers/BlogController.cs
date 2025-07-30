using Microsoft.AspNetCore.Mvc;
using MethShop.Data;
using MethShop.Models;
using System.Collections;

namespace MethShop.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDBContext _context;

        public BlogController(AppDBContext context) => _context = context;

        public IActionResult Index() //blog/
        {
            List<Blog> posts = _context.posts.ToList();
            return View(posts);
        }
    }
}
