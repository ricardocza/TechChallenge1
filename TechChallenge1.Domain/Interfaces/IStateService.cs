using TechChallenge1.Domain.Models;

namespace TechChallenge1.Domain.Interfaces;

public interface IStateService
{
    Task<State> GetByDDD(int ddd);
    Task<State> GetById(Guid id);
    Task<IEnumerable<State>> GetAll();
}
