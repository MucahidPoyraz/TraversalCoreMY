using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TraversalCoreMY.Entity.Concrete;

namespace TraversalCoreMY.DAL.Abstract
{
    public interface IGenericDal<T> where T : BaseEntity, new()
    {
        Task<List<T>> GetAllDALAsync();
        Task<List<T>> GetAllDALAsync(Expression<Func<T, bool>> filter);
        Task<T> GetByIdDALAsync(int id);
        Task<T> GetSingleDALAsync(Expression<Func<T, bool>> filter);
        Task<T> CreateDALAsync(T entity);
        Task<T> UpdateDALAsync(T entity);
        Task DeleteDALAsync(T entity);
        Task<int> CountDALAsync();
        Task<bool> ExistsDALAsync(Expression<Func<T, bool>> filter);
    }
}
