using NetCore_CRM.DataAccessLayer.Abstract;
using NetCore_CRM.DataAccessLayer.Repository;
using NetCore_CRM.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore_CRM.DataAccessLayer.EntityFramework
{
    public class EFEmployeeTaskDetail:GenericRepository<EmployeeTaskDetail>,IEmployeeTaskDetailDal
    {
    }
}
