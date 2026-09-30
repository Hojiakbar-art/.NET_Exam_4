using System.ComponentModel.DataAnnotations;


public class TicketType
{
    public int Id{get;set;}
    public int EventId{get;set;}

    [Required]
    [MaxLength(50)]
    public string Name{get;set;} = null!;
    public decimal Price{get;set;}
    public int Quantity{get;set;}
    public int SoldCount{get;set;}

    public Event Event{get;set;} = null!;
    public ICollection<Ticket> Tickets{get;set;} = [];
}