using Microsoft.AspNetCore.Mvc;

namespace SendLove.Controllers
{
    public class OccasionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

