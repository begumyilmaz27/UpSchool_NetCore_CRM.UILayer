using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore_CRM.DataAccessLayer.Abstract
{
    // IGeneric adında bir İnterface'imiz var
    //Bu dışarıdan bir T parametresi alıyor
    // Void olarak tanımladığımız temel CRUD işlemleri yapan parametreler var içinde 
    public interface IGenericDal<T>
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetByID(int id);
    }
}
