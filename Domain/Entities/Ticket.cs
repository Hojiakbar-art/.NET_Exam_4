
using System.ComponentModel.DataAnnotations;

public class Ticket
{
    public int Id {get;set;}
    public int OrderId {get;set;}
    public int TicketTypeId {get;set;}
    public int AttendeeId {get;set;}
    [Required]
    public Guid Code {get;set;}
    [Required]
    public decimal Price {get;set;}
    public DateTime PurchasedAt {get;set;}
    public bool IsCheckedIn {get;set;}
    public DateTime? CheckedInAt {get;set;}=DateTime.UtcNow;

    public TicketType TicketType {get;set;}  = null!;
    public Order Order {get;set;} = null!;
    public Attendee Attendee {get;set;} = null!;
}