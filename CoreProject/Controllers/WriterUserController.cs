using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreProject.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager writerUserManager = new WriterUserManager(new EfWriterUserDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(writerUserManager.GetList());
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddUser(AppUser p)
        {
            writerUserManager.Add(p);
            var value = JsonConvert.SerializeObject(p);
            return Json(value);
        }
    }
}
