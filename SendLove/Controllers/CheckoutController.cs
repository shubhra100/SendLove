using Microsoft.AspNetCore.Mvc;

namespace SendLove.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index(decimal total)
        {
            ViewBag.Total = total;
            return View();
        }
    }
}


