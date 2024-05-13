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

        public async Task Create(Contact contact)
        {
            await _contactRepository.Create(contact);
        }

        public Task Delete(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Contact>> GetAll()
        {
          return  await _contactRepository.GetAll();
        }

        public async Task<Contact> GetById(Guid id)
        {
            return await _contactRepository.GetById(id);
        }

        public Task Update(Guid id, Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
