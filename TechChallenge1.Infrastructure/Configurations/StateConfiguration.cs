using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechChallenge1.Core.Models;
using TechChallenge1.Domain.Models;

namespace TechChallenge1.Infrastructure.Configurations
{
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("State", "TechChallenge1");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).HasColumnType("VARCHAR(100)").IsRequired();
        }        
    }
}