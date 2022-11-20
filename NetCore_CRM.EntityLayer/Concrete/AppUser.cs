using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore_CRM.EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int> //Identity'i otomatik artan formatında görmek istediğimiz için int parametesini verdik. 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageURL { get; set; }
        public string Gender { get; set; }
        //public List<EmployeeTask> EmployeeTasks { get; set; }
    }
}
