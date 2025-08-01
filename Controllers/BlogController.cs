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

        public ActionResult Add()
        {
            return View(new Blog());
        }

        [HttpPost]
        public IActionResult Add(Blog post)
        {
            if (ModelState.IsValid)
            {
                _context.posts.Add(post);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(post);
        }

        

        // [Route("blog/{id:int}/delete")]
        // public ActionResult Delete(int id)
        // {

        // }
    }
}
