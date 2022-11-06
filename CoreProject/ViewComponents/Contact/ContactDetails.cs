using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
        ContactManager _contactManager = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = _contactManager.GetList();
            return View(values);
        }
    }
}
