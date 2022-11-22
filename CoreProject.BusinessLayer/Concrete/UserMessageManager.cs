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
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public void Add(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public UserMessage GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> GetList()
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> GetUserMessagesWithUser()
        {
            return _userMessageDal.GetUserMessagesWithUser();
        }

        public void Update(UserMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
