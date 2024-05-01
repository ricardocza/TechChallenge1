using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TechChallenge1.Core.Models;

namespace TechChallenge1.Infrastructure.Repository
{
    public class PostgreContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<State> States { get; set; }
        
        private readonly IConfiguration _configuration;

        public PostgreContext()
        {

        }

        public PostgreContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetSection("ConnectionStrings:PostgreConnection").Value);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostgreContext).Assembly);

            modelBuilder.Entity<State>().HasData(
                new State { Id = 11, Name = "11 - São Paulo" },
                new State { Id = 21, Name = "21 - Rio de Janeiro" },
                new State { Id = 22, Name = "27 - Vitória" },
                new State { Id = 31, Name = "31 - Belo Horizonte" },
                new State { Id = 41, Name = "41 - Curitiba" },
                new State { Id = 48, Name = "48 - Florianópolis" },
                new State { Id = 51, Name = "51 - Porto Alegre" },
                new State { Id = 61, Name = "61 - Brasília" },
                new State { Id = 62, Name = "62 - Goiânia" },
                new State { Id = 63, Name = "63 - Palmas" },
                new State { Id = 65, Name = "65 - Cuiabá" },
                new State { Id = 67, Name = "67 - Campo Grande" },
                new State { Id = 68, Name = "68 - Rio Branco" },
                new State { Id = 69, Name = "69 - Porto Velho" },
                new State { Id = 71, Name = "71 - Salvador" },
                new State { Id = 79, Name = "79 - Aracaju" },
                new State { Id = 81, Name = "81 - Recife" },
                new State { Id = 82, Name = "82 - Maceió" },
                new State { Id = 83, Name = "83 - João Pessoa" },
                new State { Id = 84, Name = "84 - Natal" },
                new State { Id = 85, Name = "85 - Fortaleza" },
                new State { Id = 86, Name = "86 - Teresina" },
                new State { Id = 91, Name = "91 - Belém" },
                new State { Id = 92, Name = "92 - Manaus" },
                new State { Id = 95, Name = "95 - Boa Vista" },
                new State { Id = 96, Name = "96 - Macapá" },
                new State { Id = 98, Name = "98 - São Luís" }
            );            
        }
    }
}