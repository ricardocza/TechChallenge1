using TechChallenge1.Core.Models;

namespace TechChallenge1.Domain.Models
{
    public class Contact : Entity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Guid StateId { get; set; }
        //EF RELATION 
        public State? State { get; set; }
    }
}
