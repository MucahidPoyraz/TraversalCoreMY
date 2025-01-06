using System.Collections.Generic;
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
        Task<T> GetByIdBLAsync(int id);
    }
}
