using Microsoft.AspNetCore.Mvc;

namespace Cars.Areas.Admin.Controllers
{
    public class SliderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
