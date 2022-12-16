using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreProject.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experienceManager.GetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experienceManager.Add(p);
            var value = JsonConvert.SerializeObject(p);
            return Json(value);
        }

        public IActionResult GetById(int id)
        {
            var value = experienceManager.GetById(id);
            return Json(JsonConvert.SerializeObject(value));
        }

        public IActionResult DeleteExperience(int id)
        {
            var experience = experienceManager.GetById(id);

            experienceManager.Delete(experience);
            return Ok();
        }
    }
}
