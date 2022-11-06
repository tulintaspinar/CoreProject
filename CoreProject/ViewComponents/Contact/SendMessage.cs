using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreProject.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        MessageManager _messageManager = new MessageManager(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message message)
        //{
        //    message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    message.Status = true;
        //    _messageManager.Add(message);
        //    return View();
        //}
    }
}
