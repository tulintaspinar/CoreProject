using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Portfolio
{
    public class SlideList : ViewComponent
    {
        PortfolioManager _portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = _portfolioManager.GetList();
            return View(values);
        }
    }
}
