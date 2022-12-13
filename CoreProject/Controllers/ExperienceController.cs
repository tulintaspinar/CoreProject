using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    [AllowAnonymous]
    public class ExperienceController : Controller
    {
        ExperienceManager _experienceManager = new ExperienceManager(new EfExperienceDal());

        public IActionResult Index()
        {
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
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            _experienceManager.Add(experience);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
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
