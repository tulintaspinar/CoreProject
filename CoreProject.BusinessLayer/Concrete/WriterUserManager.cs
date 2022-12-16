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
    public class WriterUserManager : IWriterUserService
    {
        IWriterUserDal _writerUserDal;

        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _writerUserDal = writerUserDal;
        }

        public void Add(AppUser t)
        {
            _writerUserDal.Insert(t);
        }

        public void Delete(AppUser t)
        {
            _writerUserDal.Delete(t);
        }

        public List<AppUser> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public AppUser GetById(int id)
        {
            return _writerUserDal.GetById(id);
        }

        public List<AppUser> GetList()
        {
            return _writerUserDal.GetList();
        }

        public void Update(AppUser t)
        {
            _writerUserDal.Update(t);
        }
    }
}
