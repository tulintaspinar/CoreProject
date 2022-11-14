﻿using CoreProject.BusinessLayer.Concrete;
using CoreProject.BusinessLayer.ValidationRules;
using CoreProject.DataAccessLayer.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager _featureManager = new FeatureManager(new EfFeatureDal());
        public IActionResult Index()
        {
            ViewBag.d1 = "Hakkımda";
            ViewBag.d2 = "Hakkımda";
            ViewBag.d3 = "Tümü";
            var values = _featureManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddFeature()
        {
            ViewBag.d1 = "Hakkımda";
            ViewBag.d2 = "Hakkımda";
            ViewBag.d3 = "Ekle";
            return View();
        }
        [HttpPost]
        public IActionResult AddFeature(Feature feature)
        {
            FeatureValidator validations = new FeatureValidator();
            ValidationResult validationResult = validations.Validate(feature);
            if (validationResult.IsValid)
            {
                _featureManager.Add(feature);
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
        public IActionResult DeleteFeature(int id)
        {
            var feature = _featureManager.GetById(id);
            _featureManager.Delete(feature);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            ViewBag.d1 = "Hakkımda";
            ViewBag.d2 = "Hakkımda";
            ViewBag.d3 = "Güncelle";
            var portfolio = _featureManager.GetById(id);
            return View(portfolio);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
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
