using NetCore_CRM.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore_CRM.DataAccessLayer.Abstract
{
    //IGenericDal bizden bir T parametresi istiyor. Biz bu T parametresine karşılık kimi göndereceğiz; Category'yi 
    public interface ICategoryDal:IGenericDal<Category>
    {

    }
}
