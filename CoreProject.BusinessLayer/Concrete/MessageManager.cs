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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;
        public MessageManager(IMessageDal messageService)
        {
            _messageDal = messageService;
        }

        public void Add(Message t)
        {
            _messageDal.Insert(t);
        }

        public void Delete(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message GetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> GetList()
        {
           return _messageDal.GetList();
        }

        public void Update(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
