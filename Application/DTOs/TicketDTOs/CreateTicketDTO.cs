public class CreateTicketDTO
{
    public int OrderId {get;set;}
    public int TicketTypeId {get;set;}
    public int AttendeeId {get;set;}
    public Guid Code {get;set;}
    public decimal Price {get;set;}
    public bool IsCheckedIn {get;set;}
}