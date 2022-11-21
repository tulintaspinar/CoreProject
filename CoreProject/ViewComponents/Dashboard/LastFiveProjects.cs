using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Dashboard
{
    public class LastFiveProjects : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
