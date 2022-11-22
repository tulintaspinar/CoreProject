using CoreProject.BusinessLayer.Abstract;
using CoreProject.DataAccessLayer.Abstract;
using CoreProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public void Add(ToDoList t)
        {
            _toDoListDal.Insert(t);
        }

        public void Delete(ToDoList t)
        {
            _toDoListDal.Delete(t);
        }

        public ToDoList GetById(int id)
        {
            return _toDoListDal.GetById(id);
        }

        public List<ToDoList> GetList()
        {
            return _toDoListDal.GetList();
        }

        public void Update(ToDoList t)
        {
            _toDoListDal.Update(t);
        }
    }
}
