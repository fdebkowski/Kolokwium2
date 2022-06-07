using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium2.Entities.Configurations;

public class EventEfConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.HasKey(e => e.IdEvent);
        builder.Property(e => e.IdEvent).UseIdentityColumn();

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.Property(e => e.DateFrom).HasColumnType("date");

        builder.Property(e => e.DateTo).HasColumnType("date");

        builder.ToTable("Event");
    }
}