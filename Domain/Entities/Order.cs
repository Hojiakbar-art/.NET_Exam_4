


using System.ComponentModel.DataAnnotations;

public class Order
{
    public int Id {get;set;}
    [Required]
    public int AttendeeId {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime? PaidAt {get;set;}
    [Required]
    public decimal TotalAmount {get;set;}
    public string Status {get;set;}=null!;

    public Attendee Attendee {get;set;} = null!;
    public ICollection<Ticket> Tickets {get;set;} = [];
}