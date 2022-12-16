using CoreProject.API.DAL.ApiContext;
using CoreProject.API.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet("GetCategoryList")]
        public IActionResult GetCategoryList()
        {
            using(var context = new Context())
            {
                return Ok(context.Categories.ToList());
            }
        }
        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            using (var context = new Context())
            {
                var category = context.Categories.Find(id);
                if(category == null)
                    return NotFound();

                return Ok(category);
            }
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            using(var context = new Context())
            {
                context.Categories.Add(category);
                context.SaveChanges();
                return Ok();
            }
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            using (var context = new Context())
            {
                var category = context.Categories.Find(id);
                if(category == null)
                    return NotFound();
                context.Categories.Remove(category);
                context.SaveChanges();
                return Ok();
            }
        }
        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            using (var context = new Context())
            {
                var newCategory = context.Find<Category>(category.CategoryID);
                if (newCategory == null)
                    return NotFound();
                newCategory.CategoryName= category.CategoryName;
                context.Categories.Update(newCategory);
                context.SaveChanges();
                return Ok();
            }
        }
    }
}
