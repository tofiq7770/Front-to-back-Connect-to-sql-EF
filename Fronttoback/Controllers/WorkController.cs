using Microsoft.AspNetCore.Mvc;

namespace Fronttoback.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
