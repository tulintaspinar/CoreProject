using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        AboutManager manager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var result = manager.GetList();
            return View(result);
        }
    }
}
