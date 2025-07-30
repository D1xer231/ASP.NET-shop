using MethShop.Data;
using MethShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace MethShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDBContext _context;

        public HomeController(ILogger<HomeController> logger, AppDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<Item> items = _context.items.ToList();

            return View(items);
        }

        public IActionResult Product(int id)
        {
            Item item = _context.items.Find(id) ?? new Item();

            return View(item);
        }

        public IActionResult Images()
        {
            List<Item> items = _context.items.Where(el => el.categoryID == 2).ToList();

            return View(items);
        }

        public IActionResult Mems()
        {
            List<Item> items = _context.items.Where(el => el.categoryID == 1).ToList();

            return View(items);
        }

        public IActionResult About() // Home/about
        {
            return View();
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
