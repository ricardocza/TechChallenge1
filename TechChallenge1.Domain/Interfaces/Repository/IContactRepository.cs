using TechChallenge1.Core.DTO;
using TechChallenge1.Core.Models;
using TechChallenge1.Domain.Models;

namespace TechChallenge1.Domain.Interfaces
{
    public interface IContactRepository : IRepository<Contact>
    {
        IEnumerable<Contact> GetByDDD(int id);
    }
}