using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetCore_CRM.EntityLayer.Concrete;
using NetCore_CRM.UILayer.Models;
using System.Threading.Tasks;

namespace NetCore_CRM.UILayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUser appUser)
        {
            var result = await _userManager.CreateAsync(appUser, appUser.PasswordHash);

            //AppUser içinde PasswordHash zaten var neden tekrar yazıyoruz?
            // await : bekleme yapmadan çalışmasını sağlıyor
            //Aşağıdaki Succeeded in gelmesi için await yazmak zorundayız. 

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "UserList");
            }
            return View();
        }

        // Modelle çalışacağız burada. Bu yüzden yeni bir Index2 ekledik ve httpget vr httpPost kısımlarını yaptık.

        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index2(UserSignUpModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = p.Username,
                    Name = p.Name,
                    Surname = p.Surname,
                    Email = p.Email,
                    PhoneNumber = p.Phonenumber
                };

                //Ekleme işlemi yapmak için Parametreden gelen değer confirm edilmiş şifreyle uyumluysa kontrol edilmeli. 
                //Model State : doğruluğunun kontrolünü sağlıyoruz. 
                if (p.Password == p.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(appUser, p.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            //İtem.description hatanın detayını gösterecek. 
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "şifreler uyuşmuyor");
                }
            }
            return View();
        }




    }
}
