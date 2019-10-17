using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TitheEnvelope.DAL.Models;
using TitheEnvelopeApi.Models.DTO.Interface;

namespace TitheEnvelopeApi.Models.DTO.Abstract
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class, IEntity
    {
        private readonly TitheContext _titheContext;

        public GenericRepository(TitheContext titheContext)
        {
            _titheContext = titheContext;
        }

        public IQueryable<T> GetAll()
        {
            return _titheContext.Set<T>().AsNoTracking();
        }
        public async Task<T> GetById(int id)
        {
            return await _titheContext.Set<T>().AsNoTracking<T>().FirstOrDefaultAsync(i => i.Id == id);
        }
        public async Task Create(T Entity)
        {
            await _titheContext.Set<T>().AddAsync(Entity);
            await _titheContext.SaveChangesAsync();
        }
        public async Task Update(int id, T Entity)
        {
            _titheContext.Set<T>().Update(Entity);
            await _titheContext.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _titheContext.Set<T>().Remove(entity);
            await _titheContext.SaveChangesAsync();
        }
        public async Task Delete(T entity)
        {
            _titheContext.Set<T>().Remove(entity);
            await _titheContext.SaveChangesAsync();
        }
    }
}
