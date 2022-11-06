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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;
        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial t)
        {
            _testimonialDal.Insert(t);
        }

        public void Delete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public Testimonial GetById(int id)
        {
           return _testimonialDal.GetById(id);
        }

        public List<Testimonial> GetList()
        {
            return _testimonialDal.GetList();
        }

        public void Update(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
