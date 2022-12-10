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
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;
        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }
        public void Add(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void Delete(Skill t)
        {
            _skillDal.Delete(t);
        }

        public List<Skill> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public Skill GetById(int id)
        {
            return _skillDal.GetById(id);
        }

        public List<Skill> GetList()
        {
            return _skillDal.GetList();
        }

        public void Update(Skill t)
        {
            _skillDal.Update(t);
        }
    }
}
