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
    public class ServiceManager : IServiceSerivce
    {
        IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Add(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void Delete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> GetList()
        {
            return _serviceDal.GetList();
        }

        public void Update(Service t)
        {
            _serviceDal.Update(t);  
        }
    }
}
