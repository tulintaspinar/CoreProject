using CoreProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.ViewComponents.Dashboard
{
    public class StatisticsDashboard2 : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.projectCount = context.Portfolios.Count();
            ViewBag.servicesCount = context.Services.Count();
            ViewBag.messagesCount = context.Messages.Count();
            return View();
        }
    }
}
