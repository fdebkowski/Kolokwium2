using Kolokwium2.Entities;

namespace Kolokwium2.DTOs;

public class EventDTO
{
    public Event Event { get; set; }
    
    public ICollection<Organiser> MainOrganisers { get; set; }
    
    public ICollection<Organiser> OtherOrganisers { get; set; }

    public EventDTO(Event @event, ICollection<Organiser> mainOrganisers, ICollection<Organiser> otherOrganisers)
    {
        Event = @event;
        MainOrganisers = mainOrganisers;
        OtherOrganisers = otherOrganisers;
    }
    
    public EventDTO(){}
}