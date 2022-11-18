using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NetCore_CRM.BusinessLayer.Abstract;
using NetCore_CRM.BusinessLayer.ValidationRules;
using NetCore_CRM.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace NetCore_CRM.UILayer.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly ICategoryService _categoryService;


        public EmployeeController(IEmployeeService employeeService, ICategoryService categoryService)
        {
            _employeeService = employeeService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values= _employeeService.TGetEmployeesByCategory();    
            return View(values);
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            List<SelectListItem> categoryValues = (from x in _categoryService.TGetList()   
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.v = categoryValues;
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            //oluşturulan EmployeeValidator sınıfını getiriyoruz burada. 

            EmployeeValidator validationRules = new EmployeeValidator();
                
            //ValidationResult sınıfını crtl. diyerek getiriyoruz ama FluentValidation.Results kısmını seçiyoruz
            //1. Validation result diyerek bir değişken oluşturuyoruz; validationRules'la beraber validate metodunu kullan employee'da kontrol ypıyoruz yani doğruluğunu sorgulamak için yapıyoruz

            ValidationResult result = validationRules.Validate(employee);

            //doğruluğunu sorgulamak için burada sorgu yazıyoruz
            if (result.IsValid)
            {
                _employeeService.TInsert(employee);
                return RedirectToAction("Index");
            }
            //result başarılı olmazsa hata mesajı döndürmeli benim yazdığım hata mesajlarını döndürmeli. 
            else
            {
                foreach (var item in result.Errors)
                {
                    //modelden gelen durumları kullanmak için ModelState kullanıyoruz. Hata durumlarını getirmek için kullanıcaz burada. 
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteEmployee(int id)
        {
            var values = _employeeService.TGetByID(id);
            _employeeService.TDelete(values);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToFalse(int id)
        {
            _employeeService.TChangeEmployeeStatusToFalse(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToTrue(int id)
        {
            _employeeService.TChangeEmployeeStatusToTrue(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateEmployee(int id)
        {
            var values = _employeeService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateEmployee(Employee employee)
        {
            var values = _employeeService.TGetByID(employee.EmployeeID);
            employee.EmployeeStatus = values.EmployeeStatus;
            _employeeService.TUpdate(employee);
            return RedirectToAction("Index");
        }



    }
}
