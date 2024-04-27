using Microsoft.AspNetCore.Mvc;

namespace Fronttoback.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
