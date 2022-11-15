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
    public class EmployeeTaskDetailManager : IEmployeeTaskDetailService
    {
        IEmployeeTaskDetailDal _employeeTaskDetailDal;

        public EmployeeTaskDetailManager(IEmployeeTaskDetailDal employeeTaskDetailDal)
        {
            _employeeTaskDetailDal = employeeTaskDetailDal;
        }

        public void TDelete(EmployeeTaskDetail t)
        {
            throw new NotImplementedException();
        }

        public EmployeeTaskDetail TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeTaskDetail> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(EmployeeTaskDetail t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(EmployeeTaskDetail t)
        {
            throw new NotImplementedException();
        }
    }
}
