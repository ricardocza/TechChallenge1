using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechChallenge1.Core.Models;
using TechChallenge1.Data.Context;
using TechChallenge1.Domain.Interfaces;
using TechChallenge1.Domain.Models;
using TechChallenge1.Infrastructure.Repository;

namespace TechChallenge1.Data.Repository
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        public ContactRepository(techchallengeDbContext dbContext) : base(dbContext)
        {

        }
        public IEnumerable<Contact> GetByDDD(int id)
        {

            //TODO
            //
            return new List<Contact>();
        }

        public  async Task<IEnumerable<Contact>> GetAll()
        {
            return await Db.Contacts.AsNoTracking().Include(d => d.State).OrderBy(c => c.Name).ToListAsync();  
        }


        public virtual async Task<Contact> GetById(Guid id)
        {
            return await Db.Contacts.AsNoTracking().Include(d => d.State).FirstOrDefaultAsync(c => c.Id == id);
        }

    }
}
