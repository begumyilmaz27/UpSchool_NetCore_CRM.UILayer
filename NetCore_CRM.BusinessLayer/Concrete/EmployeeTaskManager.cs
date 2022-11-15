using NetCore_CRM.BusinessLayer.Abstract;
using NetCore_CRM.DataAccessLayer.Abstract;
using NetCore_CRM.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore_CRM.BusinessLayer.Concrete
{
    public class EmployeeTaskManager : IEmployeeTaskService
    {
        IEmployeeTaskDal _employeeTaskDal;

        public EmployeeTaskManager(IEmployeeTaskDal employeeTaskDal)
        {
            _employeeTaskDal = employeeTaskDal;
        }

        public void TDelete(EmployeeTask t)
        {
            throw new NotImplementedException();
        }

        public EmployeeTask TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeTask> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(EmployeeTask t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(EmployeeTask t)
        {
            throw new NotImplementedException();
        }
    }
}
