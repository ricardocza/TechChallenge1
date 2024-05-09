using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechChallenge1.Domain.Interfaces;
using TechChallenge1.Domain.Models;

namespace TechChallenge1.Domain.Services
{
    
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public Task Create(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetByState(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Guid id, Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
