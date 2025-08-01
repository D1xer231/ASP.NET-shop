using MethShop.Data;
using MethShop.Models;
using Microsoft.AspNetCore.Mvc;
using CloudIpspSDK;
using CloudIpspSDK.Checkout;

namespace MethShop.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDBContext _context;

        public CartController(ILogger<CartController> logger, AppDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Item> items = new List<Item>();
            String sessionItems = HttpContext.Session.GetString("items_id") ?? "";
            if(string.IsNullOrEmpty(sessionItems))
            {
                ViewBag.NoItems = "Нет товара в корзине";
                return View(items); 
            }

            int[] itemsId =  Array.ConvertAll(sessionItems.Split(','), int.Parse);
            items = _context.items.Where(x => itemsId.Contains(x.id)).ToList();

            ViewBag.Summary = items.Sum(x => x.price);
            TempData["summary"] = ViewBag.Summary;

            return View(items);
        }

        public RedirectResult AddToCart(int id)
        {
            String idStr = id.ToString();
            String sessionItems = HttpContext.Session.GetString("items_id") ?? "";

            if (!sessionItems.Contains(idStr))
            {
                if (!sessionItems.Equals("")) sessionItems += "," + idStr;
                else sessionItems = idStr;
                HttpContext.Session.SetString("items_id", sessionItems);
            }

            return Redirect("/cart");
        }

        [HttpGet]
        public ActionResult Order()
        {
            ViewBag.sessionItems = HttpContext.Session.GetString("items_id") ?? "";
            return View();
        }

        [HttpPost]
        public IActionResult Order(Order order)
        {
            if (ModelState.IsValid)
            {
                _context.orders.Add(order);
                _context.SaveChanges();

                Config.MerchantId = 1397120;
                Config.SecretKey = "test";

                var req = new CheckoutRequest
                {
                    order_id = Guid.NewGuid().ToString("N"),
                    amount = Convert.ToInt32(TempData["summary"]) *100, //сумму в копейках поэтому умножаем на 100 ==== 100000
                    order_desc = "Оплата товара на сайте",
                    currency = "UAH"
                };
                var resp = new Url().Post(req);
                string url = "/";
                if (resp.Error == null)
                {
                    url = resp.checkout_url;
                }

                return Redirect(url);
            }

            ViewBag.sessionItems = HttpContext.Session.GetString("items_id") ?? "";

            return View();
        }
    }
}
