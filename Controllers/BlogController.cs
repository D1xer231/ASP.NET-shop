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

        // EDIT
        public IActionResult Edit(int id)
        {
            var post = _context.posts.FirstOrDefault(p => p.Id == id);
            if (post == null) return NotFound();
            return View(post);
        }

        [HttpPost]
        public IActionResult Edit(Blog post)
        {
            if (ModelState.IsValid)
            {
                _context.posts.Update(post);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(post);
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            var post = _context.posts.FirstOrDefault(p => p.Id == id);
            if (post == null) return NotFound();
            _context.posts.Remove(post);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
