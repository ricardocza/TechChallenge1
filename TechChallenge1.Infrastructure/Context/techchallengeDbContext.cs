using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechChallenge1.Domain.Models;
using TechChallenge1.Infrastructure.Repository;

namespace TechChallenge1.Data.Context
{
    public class techchallengeDbContext : DbContext
    {
        public techchallengeDbContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<State> States { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(techchallengeDbContext).Assembly);

            modelBuilder.Entity<State>().HasData(
                new State { DDD = 11, Name = "11 - São Paulo" },
                new State { DDD = 21, Name = "21 - Rio de Janeiro" },
                new State { DDD = 22, Name = "27 - Vitória" },
                new State { DDD = 31, Name = "31 - Belo Horizonte" },
                new State { DDD = 41, Name = "41 - Curitiba" },
                new State { DDD = 48, Name = "48 - Florianópolis" },
                new State { DDD = 51, Name = "51 - Porto Alegre" },
                new State { DDD = 61, Name = "61 - Brasília" },
                new State { DDD = 62, Name = "62 - Goiânia" },
                new State { DDD = 63, Name = "63 - Palmas" },
                new State { DDD = 65, Name = "65 - Cuiabá" },
                new State { DDD = 67, Name = "67 - Campo Grande" },
                new State { DDD = 68, Name = "68 - Rio Branco" },
                new State { DDD = 69, Name = "69 - Porto Velho" },
                new State { DDD = 71, Name = "71 - Salvador" },
                new State { DDD = 79, Name = "79 - Aracaju" },
                new State { DDD = 81, Name = "81 - Recife" },
                new State { DDD = 82, Name = "82 - Maceió" },
                new State { DDD = 83, Name = "83 - João Pessoa" },
                new State { DDD = 84, Name = "84 - Natal" },
                new State { DDD = 85, Name = "85 - Fortaleza" },
                new State { DDD = 86, Name = "86 - Teresina" },
                new State { DDD = 91, Name = "91 - Belém" },
                new State { DDD = 92, Name = "92 - Manaus" },
                new State { DDD = 95, Name = "95 - Boa Vista" },
                new State { DDD = 96, Name = "96 - Macapá" },
                new State { DDD = 98, Name = "98 - São Luís" }
            );
        }

    }
}
