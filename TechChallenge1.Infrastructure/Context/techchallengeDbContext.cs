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
        public techchallengeDbContext()
        {
            
        }
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
                new State { DDD = 11, Name = "São Paulo" },
                new State { DDD = 21, Name = "Rio de Janeiro" },
                new State { DDD = 22, Name = "Vitória" },
                new State { DDD = 31, Name = "Belo Horizonte" },
                new State { DDD = 41, Name = "Curitiba" },
                new State { DDD = 48, Name = "Florianópolis" },
                new State { DDD = 51, Name = "Porto Alegre" },
                new State { DDD = 61, Name = "Brasília" },
                new State { DDD = 62, Name = "Goiânia" },
                new State { DDD = 63, Name = "Palmas" },
                new State { DDD = 65, Name = "Cuiabá" },
                new State { DDD = 67, Name = "Campo Grande" },
                new State { DDD = 68, Name = "Rio Branco" },
                new State { DDD = 69, Name = "Porto Velho" },
                new State { DDD = 71, Name = "Salvador" },
                new State { DDD = 79, Name = "Aracaju" },
                new State { DDD = 81, Name = "Recife" },
                new State { DDD = 82, Name = "Maceió" },
                new State { DDD = 83, Name = "João Pessoa" },
                new State { DDD = 84, Name = "Natal" },
                new State { DDD = 85, Name = "Fortaleza" },
                new State { DDD = 86, Name = "Teresina" },
                new State { DDD = 91, Name = "Belém" },
                new State { DDD = 92, Name = "Manaus" },
                new State { DDD = 95, Name = "Boa Vista" },
                new State { DDD = 96, Name = "Macapá" },
                new State { DDD = 98, Name = "São Luís" }
            );
        }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FL5KNSI;Database=tech_challenge_01;User Id=sa;Password=Abc@1234;Trusted_Connection=True;TrustServerCertificate=True");
        }

    }
}
