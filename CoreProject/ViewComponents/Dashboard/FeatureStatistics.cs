using CoreProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.ViewComponents.Dashboard.FeatureStatistics
{
    public class FeatureStatistics : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.skillCount = context.Skills.Count();
            ViewBag.notReadMessageCount = context.Messages.Where(x=>x.Status==false).Count();
            ViewBag.readMessageCount = context.Messages.Where(x => x.Status == true).Count();
            ViewBag.experiencesCount = context.Experiences.Count();
            return View();
        }
    }
}
