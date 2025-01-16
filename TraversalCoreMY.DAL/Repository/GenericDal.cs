using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TraversalCoreMY.DAL.Abstract;
using TraversalCoreMY.DAL.Context;
using TraversalCoreMY.Entity.Concrete;

namespace TraversalCoreMY.DAL.Repository
{
    public class GenericDal<T> : IGenericDal<T> where T : class, new()
    {
        private readonly TraversalCoreMYContext _context;

        public GenericDal(TraversalCoreMYContext context)
        {
            _context = context;
        }

        public async Task<int> CountDALAsync()
        {
            try
            {
                return await _context.Set<T>().CountAsync().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                // Hataları loglayabilirsiniz
                throw new Exception("An error occurred while counting entities.", ex);
            }
        }

        public async Task<T> CreateDALAsync(T entity)
        {
            try
            {
                var createEntity = await _context.Set<T>().AddAsync(entity).ConfigureAwait(false);
                await _context.SaveChangesAsync().ConfigureAwait(false);
                return createEntity.Entity;
            }
            catch (Exception ex)
            {
                // Hataları loglayabilirsiniz
                throw new Exception("An error occurred while creating the entity.", ex);
            }
        }

        public async Task DeleteDALAsync(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                // Hataları loglayabilirsiniz
                throw new Exception("An error occurred while deleting the entity.", ex);
            }
        }

        public async Task<bool> ExistsDALAsync(Expression<Func<T, bool>> filter)
        {
            try
            {
                return await _context.Set<T>().AnyAsync(filter).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                // Hataları loglayabilirsiniz
                throw new Exception("An error occurred while checking if the entity exists.", ex);
            }
        }

        public async Task<List<T>> GetAllDALAsync()
        {
            try
            {
                return await _context.Set<T>().ToListAsync().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                // Hataları loglayabilirsiniz
                throw new Exception("An error occurred while getting all entities.", ex);
            }
        }

        public async Task<List<T>> GetAllDALAsync(Expression<Func<T, bool>> filter)
        {
            try
            {
                return await _context.Set<T>().Where(filter).ToListAsync().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                // Hataları loglayabilirsiniz
                throw new Exception("An error occurred while getting filtered entities.", ex);
            }
        }

        public async Task<T> GetByIdDALAsync(int id)
        {
            try
            {
                return await _context.Set<T>().FindAsync(id).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                // Hataları loglayabilirsiniz
                throw new Exception("An error occurred while getting the entity by id.", ex);
            }
        }

        public async Task<T> GetSingleDALAsync(Expression<Func<T, bool>> filter)
        {
            try
            {
                return await _context.Set<T>().FirstOrDefaultAsync(filter).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                // Hataları loglayabilirsiniz
                throw new Exception("An error occurred while getting the single entity.", ex);
            }
        }

        public async Task<T> UpdateDALAsync(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync().ConfigureAwait(false);
                return entity;
            }
            catch (Exception ex)
            {
                // Hataları loglayabilirsiniz
                throw new Exception("An error occurred while updating the entity.", ex);
            }
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
