using CoreProject.BusinessLayer.Concrete;
using CoreProject.BusinessLayer.ValidationRules;
using CoreProject.DataAccessLayer.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace CoreProject.Controllers
{
    public class AboutController : Controller
    {
        AboutManager _aboutManager = new AboutManager(new EfAboutDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = _aboutManager.GetList().FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            if (about.ImageUrl != null)
            {
                var extension = Path.GetExtension(about.ImageUrl);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/IMAGE/",newImageName);
                var stream = new FileStream(location, FileMode.Create);
                about.ImageUrl = "~/image/"+newImageName;
            }
            
            AboutValidator validations = new AboutValidator();
            ValidationResult validationResult = validations.Validate(about);
            if (validationResult.IsValid)
            {
                _aboutManager.Update(about);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
                return View();
            }
        }
    }
}
