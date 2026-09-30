using System.ComponentModel.DataAnnotations;


public class Venue
{
    public int Id{get;set;}

    [Required]
    [MaxLength(50)]
    public string Name{get;set;} = null!;

    [Required]
    [MaxLength(100)]
    public string Address{get;set;} = null!;

    [Required]
    [MaxLength(100)]
    public string City{get;set;} = null!;
    public int Capacity{get;set;}

    public ICollection<Event> Events {get;set;} = [];
}