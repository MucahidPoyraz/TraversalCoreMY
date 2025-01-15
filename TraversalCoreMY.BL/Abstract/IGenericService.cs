using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TraversalCoreMY.Entity.Concrete;

namespace TraversalCoreMY.BL.Abstract
{
    public interface IGenericService<T> where T : BaseEntity, new()
    {
        Task<T> CreateBLAsync(T entity);
        Task<T> UpdateBLAsync(T entity);
        Task DeleteBLAsync(T entity);
        Task<List<T>> GetAllBLAsync();
        Task<List<T>> GetAllBLAsync(Expression<Func<T, bool>> filter);
        Task<T> GetByIdBLAsync(int id);
    }
}
