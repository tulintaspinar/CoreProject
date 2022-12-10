using CoreProject.Areas.Writer.Models;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CoreProject.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditView = new UserEditViewModel();
            userEditView.Name= user.Name;
            userEditView.Surname = user.Surname;
            userEditView.ImageUrl = user.ImageUrl;
            return View(userEditView);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEdit)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if(userEdit.Image != null)
            {
                var resource = Directory.GetCurrentDirectory(); //yolu alır
                var extension = Path.GetExtension(userEdit.Image.FileName); //uzantıyı alır
                var imageName = Guid.NewGuid() + extension; //benzersiz isim oluşturur
                var saveLocation = resource + "/wwwroot/UserImage/"+imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await userEdit.Image.CopyToAsync(stream);
                user.ImageUrl = imageName; 

            }
            user.Name = userEdit.Name;
            user.Surname=userEdit.Surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEdit.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Login"); 
            }
            return View();
        }
    }
}
