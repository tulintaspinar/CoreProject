using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CoreProject.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        WriterMessageManager _writerMessage = new WriterMessageManager(new EfWriterMessageDal());

        public MessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = _writerMessage.GetListReceiverMessage(p);
            return View(messageList);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = _writerMessage.GetListSenderMessage(p);
            return View(messageList);
        }

        [HttpGet]
        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult ReceiverMessageDetails(int id)
        {
            var values = _writerMessage.GetById(id);
            return View(values);
        }

        [HttpGet]
        [Route("SenderMessageDetails/{id}")]
        public IActionResult SenderMessageDetails(int id)
        {
            var values = _writerMessage.GetById(id);
            return View(values);
        }

        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            var receiverName = await _userManager.FindByEmailAsync(p.Receiver);
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p.Date = Convert.ToDateTime(DateTime.Now);
            p.Sender = values.Email;
            p.SenderName = values.Name + " " + values.Surname;
            p.ReceiverName = receiverName.Name + " " + receiverName.Surname;
            _writerMessage.Add(p);
            return RedirectToAction("SenderMessage");
        }
    }
}
