using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
