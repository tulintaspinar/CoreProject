using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Dashboard.FeatureStatistics
{
    public class FeatureStatistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
