using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.Areas.Writer.ViewComponents
{
    public class Notification : ViewComponent
    {
        AnnouncementManager _announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values = _announcementManager.GetList().TakeLast(3).ToList();
            return View(values);
        }
    }
}
