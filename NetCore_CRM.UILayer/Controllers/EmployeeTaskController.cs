using Microsoft.AspNetCore.Mvc;
using NetCore_CRM.DataAccessLayer.Concrete;
using System.Linq;

namespace NetCore_CRM.UILayer.Controllers
{
    public class EmployeeTaskController : Controller
    {
         
        public IActionResult Index()
        {
            return View();  
        }
    }
}
