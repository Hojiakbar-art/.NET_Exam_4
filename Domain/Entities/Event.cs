using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;


public class Event
{
    public int Id{get;set;}

    [Required]
    [MaxLength(100)]
    public string Title{get;set;} = null!;

    [MaxLength(150)]
    public string? Descritpion{get;set;}
    public DateTime StartDate{get;set;}
    public DateTime EndDate{get;set;}
    public string Status {get;set;} = null!;
    public DateTime CreatedAt{get;set;}
    public DateTime UpdatedAt{get;set;}
    public bool IsDeleted{get;set;}

    public int VenueId{get;set;}
    public int OrganizerId{get;set;}
    public Venue Venue{get;set;} = null!;
    public Organizer Organizer{get;set;} = null!;

    public ICollection<Category> Categories{get;set;} = [];
    public ICollection<TicketType> TicketTypes{get;set;} = [];
    public ICollection<Review> Reviews{get;set;} = [];
}