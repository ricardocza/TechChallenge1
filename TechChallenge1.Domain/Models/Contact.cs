using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechChallenge1.Core.Models;

namespace TechChallenge1.Domain.Models
{
    public class Contact : Entity
    {
        public Guid StateId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        //EF RELATION 
        public State State { get; set; }
    }
}
