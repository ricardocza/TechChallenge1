using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechChallenge1.Core.Models;

namespace TechChallenge1.Infrastructure.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact", "TechChallenge1");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnType("INT").ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(u => u.Name).HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(u => u.StateId).HasColumnType("INT").IsRequired();
            builder.Property(u => u.Email).HasColumnType("VARCHAR(100)");
            builder.Property(u => u.Phone).HasColumnType("VARCHAR(100)").IsRequired();            
        }
    }
}