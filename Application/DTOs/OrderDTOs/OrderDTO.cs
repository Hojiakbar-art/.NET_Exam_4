public class OrderDTO
{
    
    public int AttendeeId {get;set;}
    public decimal TotalAmount {get;set;}
    public string Status {get;set;}=null!;

    public Attendee Attendee {get;set;} = null!;
    public ICollection<Ticket> Tickets {get;set;} = [];
}