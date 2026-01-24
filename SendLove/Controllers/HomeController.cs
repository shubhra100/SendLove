using Microsoft.AspNetCore.Mvc;

namespace SendLove.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
