using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TraversalCoreMY.BL.Abstract;
using TraversalCoreMY.DAL.Abstract;

namespace TraversalCoreMY.BL.Concrete
{
    public class GenericService<T> : IGenericService<T> where T : class, new()
    {
        private readonly IGenericDal<T> _genericDal;

        public GenericService(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }

        public Task<T> CreateBLAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBLAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAllBLAsync()
        {
            return await _genericDal.GetAllDALAsync();
        }

        public async Task<List<T>> GetAllBLAsync(Expression<Func<T, bool>> filter)
        {
            return await _genericDal.GetAllDALAsync(filter);
        }

        public Task<T> GetByIdBLAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateBLAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
