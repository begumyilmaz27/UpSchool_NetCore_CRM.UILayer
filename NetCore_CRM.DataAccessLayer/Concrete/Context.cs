using Microsoft.EntityFrameworkCore;
using NetCore_CRM.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore_CRM.DataAccessLayer.Concrete
{
    public class Context :DbContext 
    {
        //OnConfiguring burada bir inşaa etme yapacak. Bu inşaa bir SQL adresi tanımlama şeklinde olacak
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)        
        {
            //UseSqlServer: SQL bağlantınadresini yazmamızı sağlayan metot
            optionsBuilder.UseSqlServer("server=DESKTOP-07T8MF2\\MSSQLSERVER01;database=UpSchoolCRM;integrated security=True;");
        }

        //DbSet türünde propertyler oluşturduk. DBSet türü sınıfları alacak SQL tarafına tablo olarak yansıtacak. 
        //
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTask> EmployeeTasks { get; set; }
        public DbSet<EmployeeTaskDetail> EmployeeTaskDetails { get; set; }
    }
}
