using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium2.Entities.Configurations;

public class OrganiserEfConfiguration : IEntityTypeConfiguration<Organiser>
{
    public void Configure(EntityTypeBuilder<Organiser> builder)
    {
        builder.HasKey(e => e.IdOrganiser);
        builder.Property(e => e.IdOrganiser).UseIdentityColumn();

        builder.Property(e => e.IdOrganiser).ValueGeneratedOnAdd();

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.ToTable("Organisers");
    }
}