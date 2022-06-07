namespace Kolokwium2.Entities;

public class Organiser
{
    public int IdOrganiser { get; set; }
    
    public string Name { get; set; }
    
    public virtual ICollection<EventOrganiser> EventOrganisers { get; set; }

    public Organiser()
    {
        EventOrganisers = new HashSet<EventOrganiser>();
    }
}