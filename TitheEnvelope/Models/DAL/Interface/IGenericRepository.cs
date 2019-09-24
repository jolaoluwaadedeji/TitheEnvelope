using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitheEnvelopeApi.Models.DAL.Interface
{
    interface IGenericRepository<TEntity> where TEntity: class
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int Id);
        Task Create(TEntity entity);
        Task Delete(int Id);
        Task Update(int Id, TEntity entity);

    }
}
