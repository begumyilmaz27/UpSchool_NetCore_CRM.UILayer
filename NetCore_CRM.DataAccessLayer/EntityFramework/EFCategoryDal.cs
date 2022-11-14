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
    //Entity olarak Category ile çalıştığımız için <> içine Category class'ı verdik. 
    // İkinci miras olarak ICategoryDal'ı verdik. nedeni sadece Category sınıfına özgü Interface içine metot yazabilirim. 
    public class EFCategoryDal: GenericRepository<Category>, ICategoryDal
    {
    }
}
