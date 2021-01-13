﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Domain.Entites;

namespace WebStore.Project.Backend.Domain.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task Create(TEntity entity);
        Task<TEntity> GetById(int id);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task SaveChanges();
    }
}
