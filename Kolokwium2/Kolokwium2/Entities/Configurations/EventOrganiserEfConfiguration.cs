using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium2.Entities.Configurations;

public class EventOrganiserEfConfiguration : IEntityTypeConfiguration<EventOrganiser>
{
    public void Configure(EntityTypeBuilder<EventOrganiser> builder)
    {
        builder.HasKey(e => new { e.IdEvent, e.IdOrganiser });
        builder.Property(e => e.MainOrganiser).IsRequired().HasColumnType("bit");

        builder.HasOne(e => e.IdEventNavigation)
            .WithMany(e => e.EventOrganisers)
            .HasForeignKey(e => e.IdEvent)
            .HasConstraintName("EventOrganiser_Event")
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(e => e.IdOrganiserNavigation)
            .WithMany(e => e.EventOrganisers)
            .HasForeignKey(e => e.IdOrganiser)
            .HasConstraintName("EventOrganiser_Organiser")
            .OnDelete(DeleteBehavior.ClientSetNull);
        
        builder.ToTable("Event_Organiser");
    }
}