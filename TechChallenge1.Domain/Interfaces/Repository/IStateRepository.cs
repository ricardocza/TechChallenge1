using TechChallenge1.Core.Models;
using TechChallenge1.Domain.Models;

namespace TechChallenge1.Domain.Interfaces
{
    public interface IStateRepository : IRepository<State>
    {
        Task<State> GetByDDD(int ddd);
    }
}
