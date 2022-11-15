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
    //burada <T> parametresi vermemiz gerekiyor mu?
    //Hayır çünkü ICategoryService içini yazarken
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //Dependency Injection nedir?
        //Bağımlılıktan kurtulmak için yapıcı metot içine enjekte yapmak
        //Bağımlılıkları minimize etmek

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        //Void türünde olmadığı için başına RETURN eklememiz gerekiyor. 
        public Category TGetByID(int id)
        {
            return _categoryDal.GetByID(id);   
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetList();
        }

        public void TInsert(Category t)
        {
            _categoryDal.Insert(t); 
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t); 
        }
    }
}
