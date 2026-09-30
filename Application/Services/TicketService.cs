public class TicketService(ITicketRepository ticketRepository) : ITicketService
{
    private ITicketRepository repository=ticketRepository;

    public async Task<ApiResponse<bool>> AddTicket(CreateTicketDTO ticketDTO)
    {
        var tic=new Ticket()
        {
            OrderId=ticketDTO.OrderId,
            AttendeeId=ticketDTO.AttendeeId,
            TicketTypeId=ticketDTO.TicketTypeId,
            Code=ticketDTO.Code,
            Price=ticketDTO.Price  
        };
        var res=await repository.AddTicketAsync(tic);
        return res==true
        ? new ApiResponse<bool>(System.Net.HttpStatusCode.OK, "Added" ,res)
        : new ApiResponse<bool>(System.Net.HttpStatusCode.InternalServerError, "something went wrong!", res);
    }

    public async Task<ApiResponse<List<TicketDTO>>> GetTickets()
    {
        var data=await repository.GetTicketsAsync();
        List<TicketDTO> ticketDTOs=new List<TicketDTO>();
        foreach (var item in ticketDTOs)
        {
            var tic=new TicketDTO()
            {
                OrderId=item.OrderId,
            AttendeeId=item.AttendeeId,
            TicketTypeId=item.TicketTypeId,
            Code=item.Code,
            Price=item.Price 
            };
            ticketDTOs.Add(tic);
        }
        return new ApiResponse<List<TicketDTO>>(System.Net.HttpStatusCode.OK, "The list of tickets: ", ticketDTOs);
    }
}