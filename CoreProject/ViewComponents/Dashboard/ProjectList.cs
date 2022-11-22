using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Dashboard
{
    public class ProjectList : ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.GetList();
            return View(values);
        }
    }
}
