using System.Linq.Expressions;
using TechChallenge1.Core.Models;

namespace TechChallenge1.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(Guid id);
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(Guid id);

        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);

        Task<int> SaveChanges();
    }
}