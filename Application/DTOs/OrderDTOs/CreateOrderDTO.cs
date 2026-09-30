public class CreateOrderDTO
{
    public int AttendeeId {get;set;}
    public decimal TotalAmount {get;set;}
    public string Status {get;set;}=null!;
}