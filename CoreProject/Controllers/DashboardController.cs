using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.d1 = "Dashboard";
            ViewBag.d2 = "Dashboard";
            ViewBag.d3 = "Anasayfa";
            return View();
        }
    }
}
