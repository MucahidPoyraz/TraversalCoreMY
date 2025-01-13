using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TraversalCoreMY.BL.Abstract;
using TraversalCoreMY.DAL.Abstract;
using TraversalCoreMY.Entity.Concrete;

namespace TraversalCoreMY.BL.Concrete
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntity, new()
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
