using System.ComponentModel.DataAnnotations;


public class Organizer
{
    public int Id{get;set;}

    [Required]
    [MaxLength(50)]
    public string CompanyName{get;set;} = null!;

    [Required]
    [MaxLength(100)]
    public string ContactEmail{get;set;} = null!;

    [MaxLength(50)]
    public string? Phone{get;set;}
    
    public ICollection<Event> Events {get;set;} = [];
}