using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager _serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.d1 = "HİZMETLER";
            ViewBag.d2 = "Hizmetler";
            ViewBag.d3 = "Tümü";
            var values = _serviceManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.d1 = "HİZMETLER";
            ViewBag.d2 = "Hizmetler";
            ViewBag.d3 = "Ekle";
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceManager.Add(service);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var service = _serviceManager.GetById(id);
            _serviceManager.Delete(service);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            ViewBag.d1 = "HİZMETLER";
            ViewBag.d2 = "Hizmetler";
            ViewBag.d3 = "Düzenle";
            var values = _serviceManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _serviceManager.Update(service);
            return RedirectToAction("Index");
        }
    }
}
