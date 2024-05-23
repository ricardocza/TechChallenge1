using System.Linq.Expressions;
using TechChallenge1.Core.DTO;
using TechChallenge1.Domain.Models;

namespace TechChallenge1.Domain.Interfaces
{
    public interface IContactService
    {
        Task Create (Contact contact);
        Task Delete (Guid id);
        Task Update (Contact contact);

        Task<Contact> GetById (Guid id);
        Task<IEnumerable<Contact>> GetAll ();
        ReturnTableDto<Contact> GetRadzenList(string filter, string order, int? skip, int? take, Expression<Func<Contact, Contact>> select);


    }
}
