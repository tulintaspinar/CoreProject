using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager _experienceManager = new ExperienceManager(new EfExperienceDal());

        public IActionResult Index()
        {
            ViewBag.d1 = "Dashboard";
            ViewBag.d2 = "Deneyimler";
            ViewBag.d3 = "Tümü";
            var values = _experienceManager.GetList();
            return View(values);
        }
        public IActionResult DeleteExperience(int id)
        {
            var experience = _experienceManager.GetById(id);
            _experienceManager.Delete(experience);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.d1 = "Dashboard";
            ViewBag.d2 = "Deneyim";
            ViewBag.d3 = "Ekle";
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            ViewBag.d1 = "Dashboard";
            ViewBag.d2 = "Deneyim";
            ViewBag.d3 = "Güncelle";
            _experienceManager.Add(experience);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            ViewBag.d1 = "Dashboard";
            ViewBag.d2 = "Deneyim";
            ViewBag.d3 = "Güncelle";
            var values = _experienceManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            _experienceManager.Update(experience);
            return RedirectToAction("Index");
        }
    }
}
