using TechChallenge1.Core.DTO;
using TechChallenge1.Core.Models;

namespace TechChallenge1.Infrastructure.Interfaces
{
    public interface IContactRepository : IRepository<Contact>
    {
        List<ContactDto> GetByDDD(int id);
    }
}