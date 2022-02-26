using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisUygulamasiUdemy.Data.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {


        void Add(T entity);

        //sorgu yapmak icin expression kullaniyoruz.
        T GetFirstOrDefaul(Expression<Func<T, bool>> filter,
            string? includeProperties = null);

        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter,
            string? includeProperties = null);
        void Update(T entity);
            
    }
   
}
