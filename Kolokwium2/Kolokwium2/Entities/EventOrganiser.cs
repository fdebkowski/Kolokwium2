namespace Kolokwium2.Entities;

public class EventOrganiser
{
    public int IdEvent { get; set; }
    
    public int IdOrganiser { get; set; }
    
    public Boolean MainOrganiser { get; set; }
    
    public virtual Event IdEventNavigation { get; set; }
    
    public virtual Organiser IdOrganiserNavigation { get; set; }
}