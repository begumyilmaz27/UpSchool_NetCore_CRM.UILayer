using Microsoft.EntityFrameworkCore;
using NetCore_CRM.DataAccessLayer.Abstract;
using NetCore_CRM.DataAccessLayer.Concrete;
using NetCore_CRM.DataAccessLayer.Repository;
using NetCore_CRM.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore_CRM.DataAccessLayer.EntityFramework
{
    public class EFEmployeeDal : GenericRepository<Employee>, IEmployeeDal
    {
        public void ChangeEmployeeStatusToFalse(int id)
        {
            //sadece metot çağrıldığında bu kısım çalışsın istediğimiz için context'i buraya yazıyoruz. 
            using var context = new Context();
            {
                var values = context.Employees.Find(id);
                values.EmployeeStatus = false;
                context.SaveChanges();
            }
        }

        public void ChangeEmployeeStatusToTrue(int id)
        {
            using (var context = new Context())
            {
                var values = context.Employees.Find(id);
                values.EmployeeStatus = true;
                context.SaveChanges();
            }
        }

        public List<Employee> GetEmployeesByCategory()
        {
            using (var context=new Context())
            {
                return context.Employees.Include(e => e.Category).ToList(); 
            }
        }
    }
}
