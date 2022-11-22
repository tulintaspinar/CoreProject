using CoreProject.BusinessLayer.Concrete;
using CoreProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        ToDoListManager toDoListManager = new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
            return View(toDoListManager.GetList());
        }
    }
}
