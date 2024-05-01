using TechChallenge1.Core.Models;

namespace TechChallenge1.Infrastructure.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        IList<T> GetAll();
        T GetById(int id);
        void Create(T entidade);
        void Update(T entidade);
        void Delete(int id);
    }
}