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
    public class ProductManager : IProductService
    {
        IProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public void TDelete(Product t)
        {
            productDal.Delete(t);
        }

        public Product TGetByID(int id)
        {
            return productDal.GetByID(id);
        }

        public List<Product> TGetList()
        {
            return productDal.GetList();
        }

        public void TInsert(Product t)
        {
            productDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            productDal.Update(t);
        }
    }
}
