using Fronttoback.DAL;
using Fronttoback.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fronttoback.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();

            return View(sliders);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Work()
        {
            return View();
        }
    }
}
