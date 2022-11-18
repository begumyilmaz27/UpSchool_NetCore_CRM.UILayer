using FluentValidation;
using NetCore_CRM.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore_CRM.BusinessLayer.ValidationRules
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        //rulefor: kural metotu. normal yazdığımızda çıkmıyor ama constructure içinde yazdığımız için çıkıyor. 
        //ctor yazınca constructure oluşuyor
        //ruleFor FluentValidation beraber geliyor
        //parantez içinde ilk olarak property alıyor
        public EmployeeValidator()
        {
            RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("personel adını boş geçemezsiniz!");
            RuleFor(x => x.EmployeeSurname).NotEmpty().WithMessage("personel soyadını boş geçemezsiniz!");
            RuleFor(x => x.EmployeeName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri giriniz!");
            RuleFor(x => x.EmployeeName).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri giriniz!");
        }

    }
}
