using Microsoft.EntityFrameworkCore;
using TechChallenge1.Data.Context;
using TechChallenge1.Domain.Interfaces;
using TechChallenge1.Domain.Models;
using TechChallenge1.Infrastructure.Repository;

namespace TechChallenge1.Data.Repository;

public class StateRepository : Repository<State>, IStateRepository
{
    public StateRepository(techchallengeDbContext db) : base(db)
    {
    }

    public async Task<IEnumerable<State>> GetAll()
    {
        return await Db.States.AsNoTracking().Include(d => d.Contacts).OrderBy(c => c.Name).ToListAsync();
    }

    public override async Task<State> GetById(Guid id)
    {
        return await Db.States.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<State> GetByDDD(int ddd)
    {
        return await DbSet.FirstOrDefaultAsync(s => s.DDD == ddd); ;
    }
}
