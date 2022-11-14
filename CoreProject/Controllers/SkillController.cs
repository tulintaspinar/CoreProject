using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class SkillController : Controller
    {
        SkillManager _skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.d1 = "Dashboard";
            ViewBag.d2 = "Yetenekler";
            ViewBag.d3 = "Tümü";
            var values = _skillManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.d1 = "Dashboard";
            ViewBag.d2 = "Yetenekler";
            ViewBag.d3 = "Ekle";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            _skillManager.Add(skill);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var skill = _skillManager.GetById(id);
            _skillManager.Delete(skill);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            ViewBag.d1 = "Dashboard";
            ViewBag.d2 = "Yetenekler";
            ViewBag.d3 = "Güncelle";
            var skill = _skillManager.GetById(id);
            return View(skill);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            _skillManager.Update(skill);
            return RedirectToAction("Index");
        }
    }
}
