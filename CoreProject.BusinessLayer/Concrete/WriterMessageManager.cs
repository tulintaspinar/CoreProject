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
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public void Add(WriterMessage t)
        {
            _writerMessageDal.Insert(t);
        }

        public void Delete(WriterMessage t)
        {
            _writerMessageDal.Delete(t);
        }

        public WriterMessage GetById(int id)
        {
            return _writerMessageDal.GetById(id);
        }

        public List<WriterMessage> GetList()
        {
            return _writerMessageDal.GetList();
        }

        public void Update(WriterMessage t)
        {
            _writerMessageDal.Update(t);
        }
    }
}
