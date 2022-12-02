using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreProject.Areas.Writer.ViewComponents
{
    public class Navbar :ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public Navbar(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.UserImage = user.ImageUrl;
            return View(); 
        }
    }
}
