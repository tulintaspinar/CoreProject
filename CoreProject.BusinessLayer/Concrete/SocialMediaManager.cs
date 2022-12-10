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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;
        public SocialMediaManager(ISocialMediaDal socialMedia)
        {
            _socialMediaDal = socialMedia;
        }

        public void Add(SocialMedia t)
        {
            _socialMediaDal.Insert(t);
        }

        public void Delete(SocialMedia t)
        {
            _socialMediaDal.Delete(t);
        }

        public List<SocialMedia> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public SocialMedia GetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public List<SocialMedia> GetList()
        {
            return _socialMediaDal.GetList();
        }

        public void Update(SocialMedia t)
        {
            _socialMediaDal.Update(t);
        }
    }
}
