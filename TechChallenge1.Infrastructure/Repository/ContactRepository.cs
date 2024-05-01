using TechChallenge1.Core.DTO;
using TechChallenge1.Core.Models;
using TechChallenge1.Infrastructure.Interfaces;

namespace TechChallenge1.Infrastructure.Repository
{
    public class ContactRepository : EFRepository<Contact>, IContactRepository
    {
        public ContactRepository(PostgreContext context) : base(context)
        {

        }

        public List<ContactDto> GetByDDD(int id)
        {            
            var contacts = _context.Contacts.Where<Contact>(c => c.StateId == id) ?? throw new Exception("Registro não encontrado!");

            if(contacts?.Count() > 0)
            {
                return ContactDto.FromRange(contacts);
            }

            return new List<ContactDto>();
        }
    }
}