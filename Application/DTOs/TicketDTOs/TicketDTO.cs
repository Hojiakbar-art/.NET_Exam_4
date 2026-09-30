public class TicketDTO
{
    

    public int OrderId {get;set;}
    public int TicketTypeId {get;set;}
    public int AttendeeId {get;set;}
    public Guid Code {get;set;}
    public decimal Price {get;set;}
    public TicketType TicketType {get;set;}  = null!;
    public Order Order {get;set;} = null!;
    public Attendee Attendee {get;set;} = null!;
}