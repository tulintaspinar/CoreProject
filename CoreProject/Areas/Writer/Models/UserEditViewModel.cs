using Microsoft.AspNetCore.Http;

namespace CoreProject.Areas.Writer.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
    }
}
