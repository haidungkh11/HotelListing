using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HotelListing.IRespository
{
    public interface IGenerticRespository<T> where T : class
    {

        Task<IList<T>> GetAll(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<string> include = null
            );
        Task<T> Get(Expression<Func<T, bool>> expression, List<String> include = null);
        Task Insert(T entity);
        Task InsertRange(IEnumerable<T> entities);
        Task Delete(int id);
        void DeleteRange(IEnumerable<T> entities);
        void Update(T entity);
    }
}
