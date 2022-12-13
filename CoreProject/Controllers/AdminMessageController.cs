using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CoreProject.Controllers
{
    public class AdminMessageController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AdminMessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "tulin@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            string p;
            p = "tulin@gmail.com";
            var values = writerMessageManager.GetListSenderMessage(p);
            return View(values);
        }
        public IActionResult DeleteMessage(int id)
        {
            var value = writerMessageManager.GetById(id);
            writerMessageManager.Delete(value);
            return RedirectToAction("Index", "ReceiverMessageList");
        }
        public IActionResult SenderDeleteMessage(int id)
        {
            var value = writerMessageManager.GetById(id);
            writerMessageManager.Delete(value);
            return RedirectToAction("Index", "SenderMessageList");
        }

        [HttpGet]
        public IActionResult DetailMessage(int id)
        {
            var values = writerMessageManager.GetById(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult SenderDetailMessage(int id)
        {
            var values = writerMessageManager.GetById(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddMessage(WriterMessage message)
        {
            var receiver = await _userManager.FindByEmailAsync(message.Receiver);

            message.Sender = "tulin@gmail.com";
            message.SenderName = "Tülin Taşpınar";
            message.Date = Convert.ToDateTime(DateTime.Now);
            message.ReceiverName= receiver.Name+" "+receiver.Surname;
            writerMessageManager.Add(message);
            return RedirectToAction("SenderMessageList");
        }
    }
}
