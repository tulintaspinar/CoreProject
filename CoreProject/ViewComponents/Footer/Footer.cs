using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Footer
{
    public class Footer:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
