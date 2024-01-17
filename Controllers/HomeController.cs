using Cars.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cars.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using CarsDbContext context = new CarsDbContext();
            var sliders = await context.Sliders.ToListAsync();
            return View(sliders);
        }
    }
}
