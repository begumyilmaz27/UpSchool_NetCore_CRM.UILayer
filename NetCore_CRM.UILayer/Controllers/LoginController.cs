using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetCore_CRM.EntityLayer.Concrete;
using System.Threading.Tasks;

namespace NetCore_CRM.UILayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUser appUser)
        {
            //PasswordSignInAsync 4 tane parametre istiyor;
            //Bu parametrelerden biri olan "bool isPersistent" kişi çerezlere kaydolsun mu kaydolmasın mı onu soruyor.
            var result = await _signInManager.PasswordSignInAsync(appUser.UserName, appUser.PasswordHash, false, true);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "User");
            }
            return View();
        }
    }
}
