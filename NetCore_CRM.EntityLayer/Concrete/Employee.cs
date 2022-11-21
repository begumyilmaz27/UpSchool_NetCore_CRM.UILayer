using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore_CRM.EntityLayer.Concrete
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeMail { get; set; }
        public string EmployeeImage { get; set; }

        //..........................................
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        
        //Employew tablom içinde bir CategoryID sütunu olacak ve bunu Category sınıfınfan türetilen bir Category propertisi aracılığı ilişkiyi kuracak. 

        //..........................................
        public bool EmployeeStatus { get; set; }
        public List<EmployeeTask> EmployeeTasks { get; set; }
    }
}
