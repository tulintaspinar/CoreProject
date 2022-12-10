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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;
        public ExperienceManager(IExperienceDal experienceSDal)
        {
            _experienceDal = experienceSDal;
        }

        public void Add(Experience t)
        {
            _experienceDal.Insert(t);
        }

        public void Delete(Experience t)
        {
            _experienceDal.Delete(t);
        }

        public List<Experience> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public Experience GetById(int id)
        {
           return _experienceDal.GetById(id);
        }

        public List<Experience> GetList()
        {
            return _experienceDal.GetList();
        }

        public void Update(Experience t)
        {
            _experienceDal.Update(t);
        }
    }
}
