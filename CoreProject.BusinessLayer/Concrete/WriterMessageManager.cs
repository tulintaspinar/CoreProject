using CoreProject.BusinessLayer.Abstract;
using CoreProject.DataAccessLayer.Abstract;
using CoreProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public List<WriterMessage> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public WriterMessage GetById(int id)
        {
            return _writerMessageDal.GetById(id);
        }

        public List<WriterMessage> GetList()
        {
            return _writerMessageDal.GetList();
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _writerMessageDal.GetByFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _writerMessageDal.GetByFilter(x => x.Sender == p);
        }

        public void Update(WriterMessage t)
        {
            _writerMessageDal.Update(t);
        }
    }
}
