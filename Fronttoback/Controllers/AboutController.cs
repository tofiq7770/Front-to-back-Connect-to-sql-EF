using Microsoft.AspNetCore.Mvc;

namespace Fronttoback.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
