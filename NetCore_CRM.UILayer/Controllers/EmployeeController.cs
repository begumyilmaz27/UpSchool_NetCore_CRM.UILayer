using Microsoft.AspNetCore.Mvc;
using NetCore_CRM.BusinessLayer.Abstract;

namespace NetCore_CRM.UILayer.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var values= _employeeService.TGetList();    
            return View();
        }
    }
}
