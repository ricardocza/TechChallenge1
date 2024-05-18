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

            modelBuilder.Entity<State>().HasData(StateList.List);
        }

    }
}
