using CoreProject.DataAccessLayer.Concrete;
using CoreProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreProject.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.User = user.Name + " " + user.Surname;


            //Weather API
            string api = "9f9e9706e0ede9cd6b32befaee1ebceb";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Trabzon&mode=xml&lang=tr&units=metric&appid="+api;
            XDocument document = XDocument.Load(connection);
            ViewBag.havaDurumu = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //statistics
            Context c = new Context();
            ViewBag.GelenMesaj = 0;
            ViewBag.DuyuruSayisi = c.Announcements.Count();
            ViewBag.ToplamKullanici = c.Users.Count();
            ViewBag.ToplamYetenek = c.Skills.Count();
            return View();
        }
    }
}
/*
 * https://api.openweathermap.org/data/2.5/weather?q=Trabzon&mode=xml&lang=tr&units=metric&appid=9f9e9706e0ede9cd6b32befaee1ebceb
 */