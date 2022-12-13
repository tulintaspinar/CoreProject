using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = messageManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult DetailContact(int id)
        {
            var values = messageManager.GetById(id);
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var values = messageManager.GetById(id);
            messageManager.Delete(values);
            return RedirectToAction("Index");
        }
    }
}
