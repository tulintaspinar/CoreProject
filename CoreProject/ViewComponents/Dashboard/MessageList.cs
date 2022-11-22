using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        UserMessageManager messageManager=new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var result = messageManager.GetUserMessagesWithUser();
            return View(result);
        }
    }
}
