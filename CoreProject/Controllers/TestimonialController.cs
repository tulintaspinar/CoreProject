using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var values = testimonialManager.GetList();
            return View(values);
        }
        public IActionResult Delete(int id)
        {
            var value = testimonialManager.GetById(id);
            testimonialManager.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var values = testimonialManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Update(Testimonial testimonial)
        {
            testimonialManager.Update(testimonial);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            var values = testimonialManager.GetById(id);
            return View(values);
        }
    }
}
