using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Abstract
{
    public interface IGenericRepository<T> where T:IEntityBase
    {
        //Listeleme
        List<T> GetAll();

        //Filtreli listeleme
        List<T> GetAll(Expression<Func<T, bool>> expression);

        //Geliştirme
        T Find(int id);

        //Kaydetme
        T Add(T item);

        //Async kaydetme
        Task<T> AddAsync(T item);

        //Güncelleme
        T Update(T item);



        //Silme
        bool Delete(int id);

        bool Delete(T item);

        


        //Iqueryable Listeleme
        IQueryable<T> GetQueryable();
    }
}
