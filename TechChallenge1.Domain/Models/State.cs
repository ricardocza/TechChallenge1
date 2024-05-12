﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechChallenge1.Core.Models;

namespace TechChallenge1.Domain.Models
{
    public class State : Entity
    {
        public int DDD { get; set; }

        public string Name { get; set; }

        // EF Relations
        //public IEnumerable<Contact> Contacts { get; set; }

    }
}
