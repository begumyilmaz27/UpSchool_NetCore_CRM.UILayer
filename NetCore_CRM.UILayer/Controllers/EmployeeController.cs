using Microsoft.AspNetCore.Mvc;

namespace NetCore_CRM.UILayer.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
