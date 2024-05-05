using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechChallenge1.Domain.Models;

namespace TechChallenge1.Domain.Interfaces
{
    public interface IContactService
    {
        Task Create (Contact contact);
        Task Delete (Contact contact);
        Task Update (Contact contact);
        Task<IEnumerable<Contact>> GetAll ();
        Task<IEnumerable<Contact>> GetByState (int id);
    }
}
