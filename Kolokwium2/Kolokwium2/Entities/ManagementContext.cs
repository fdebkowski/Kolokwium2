using System.Reflection;
using Kolokwium2.Entities.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Kolokwium2.Entities;

public class ManagementContext : DbContext
{
    public ManagementContext() { }
    
    public ManagementContext(DbContextOptions options) : base(options) { }

    public DbSet<Event> Events { get; set; }
    public DbSet<Organiser> Organisers { get; set; }
    public DbSet<EventOrganiser> EventOrganisers { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EventEfConfiguration).GetTypeInfo().Assembly);
    }
}