using CoreProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.BusinessLayer.Abstract
{
    public interface IGenericService<T>where T : class
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetById(int id);
        List<T> GetByFilter();
    }
}
