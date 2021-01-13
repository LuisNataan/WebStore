using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Domain.Entites;

namespace WebStore.Project.Backend.Domain.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetById(int id);
        Task<TEntity> Create(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Delete(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task SaveChanges();
    }
}
