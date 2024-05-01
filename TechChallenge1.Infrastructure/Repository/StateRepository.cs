using TechChallenge1.Core.Models;
using TechChallenge1.Infrastructure.Interfaces;

namespace TechChallenge1.Infrastructure.Repository
{
    public class StateRepository : EFRepository<State>, IStateRepository
    {
        public StateRepository(PostgreContext context) : base(context) { }
    }
}
