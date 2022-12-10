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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature t)
        {
            _featureDal.Insert(t);
        }

        public void Delete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public List<Feature> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public Feature GetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public List<Feature> GetList()
        {
            return _featureDal.GetList();
        }

        public void Update(Feature t)
        {
            _featureDal.Update(t);
        }
    }
}
