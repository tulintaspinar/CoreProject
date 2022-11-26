using CoreProject.DataAccessLayer.Abstract;
using CoreProject.DataAccessLayer.Concrete;
using CoreProject.DataAccessLayer.Repository;
using CoreProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DataAccessLayer.EntityFramework
{
    public class EfUserMessageDal : GenericRepository<UserMessage>, IUserMessageDal
    {
        public List<UserMessage> GetUserMessagesWithUser()
        {
            using (var context = new Context())
            {
                return context.UserMessages.Include(x => x.User).ToList();
            }
        }
    }
}
