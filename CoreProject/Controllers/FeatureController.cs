using CoreProject.BusinessLayer.Concrete;
using CoreProject.BusinessLayer.ValidationRules;
using CoreProject.DataAccessLayer.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager _featureManager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = _featureManager.GetList().FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            FeatureValidator validations = new FeatureValidator();
            ValidationResult validationResult = validations.Validate(feature);
            if (validationResult.IsValid)
            {
                _featureManager.Update(feature);
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
