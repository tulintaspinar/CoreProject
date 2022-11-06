using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager manager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = manager.GetList();
            return View(values);
        }
    }
}
