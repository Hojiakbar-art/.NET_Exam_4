using System.ComponentModel.DataAnnotations;



public class Attendee
{
    public int Id{get;set;}

    [Required]
    [MaxLength(100)]
    public string FullName{get;set;} = null!;

    [Required]
    [MaxLength(100)]
    public string Email{get;set;} = null!;
    public DateTime RegisteredAt{get;set;}=DateTime.UtcNow;
    public AttendeeProfile Profile {get; set;} = null!;
    public ICollection<Order> Orders { get; set;}= [];
    public ICollection<Ticket> Tickets { get; set;} = [];
    public ICollection<Review> Reviews { get; set;} = [];
}