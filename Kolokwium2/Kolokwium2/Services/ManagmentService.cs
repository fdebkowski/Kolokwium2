using Kolokwium2.DTOs;
using Kolokwium2.Entities;

namespace Kolokwium2.Services;

public class ManagmentRepository
{
    public ManagementContext _context;
    
    public ManagmentRepository(ManagementContext context)
    {
        _context = context;
    }
    
    public IEnumerable<EventDTO> GetAllEvents(bool isDateToPresent)
    {
        var events = _context.Events.ToList();
        var organisers = _context.Organisers.ToList();
        var eventOrganisers = _context.EventOrganisers.ToList();
        var eventDtos = new List<EventDTO>();
        foreach (var e in events)
        {
            if (isDateToPresent)
            {
                if (e.DateTo == null)
                {
                    continue;
                }
            }
            var eventDto = new EventDTO();
            eventDto.Event = e;
            eventDto.MainOrganisers = new List<Organiser>();
            eventDto.OtherOrganisers = new List<Organiser>();
            foreach (var eventOrganiser in eventOrganisers)
            {
                if (eventOrganiser.IdEvent == e.IdEvent)
                {
                    foreach (var organiser in organisers)
                    {
                        if (eventOrganiser.IdOrganiser == organiser.IdOrganiser)
                        {
                            if (eventOrganiser.MainOrganiser)
                            {
                                eventDto.MainOrganisers.Add(organiser);
                            }
                            else
                            {
                                eventDto.OtherOrganisers.Add(organiser);
                            }
                        }
                    }
                }
            }

            eventDtos.Add(eventDto);
        }
        return eventDtos;
    }
}