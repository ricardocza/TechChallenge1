using TechChallenge1.Core.DTO;

namespace TechChallenge1.Web.WebServices.Interfaces;
public interface IStateWebService
{
    Task<IEnumerable<StateDto>> GetAllStates();
    Task<StateDto?> GetStateByDDD(int ddd);
    Task<StateDto?> GetStateById(Guid id);
}
