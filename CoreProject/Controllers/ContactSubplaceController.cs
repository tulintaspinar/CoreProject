using CoreProject.BusinessLayer.Concrete;
using CoreProject.BusinessLayer.ValidationRules;
using CoreProject.DataAccessLayer.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;

namespace CoreProject.Controllers
{
    public class ContactSubplaceController : Controller
    {
        ContactManager _contactManager = new ContactManager(new EfContactDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = _contactManager.GetById(1) ;
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            _contactManager.Update(contact);
            return View();
        }   
    }
}
