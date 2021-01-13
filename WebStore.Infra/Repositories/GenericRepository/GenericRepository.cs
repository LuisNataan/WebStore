﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entites;
using WebStore.Project.Backend.Domain.Interfaces;

namespace WebStore.Project.Backend.Infra.Repositories.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly MainContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(MainContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public async Task Create(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }
        public async Task Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public async Task Delete(TEntity entity)
        {
            _dbSet.Update(entity);
        }
        public virtual async Task<TEntity> GetById(int id)
        {
            return await _dbSet
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id && !x.Deletado);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await Query().Where(x => !x.Deletado).ToListAsync();
        }

        public async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> Query() => _dbSet.AsNoTracking();
    }
}
