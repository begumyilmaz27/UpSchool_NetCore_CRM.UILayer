using Microsoft.AspNetCore.Mvc;
using NetCore_CRM.DataAccessLayer.Concrete;
using System.Linq;

namespace NetCore_CRM.UILayer.Controllers
{
    public class CustomerController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var values = c.Customers.ToList();
            return View(values);
        }
    }
}
