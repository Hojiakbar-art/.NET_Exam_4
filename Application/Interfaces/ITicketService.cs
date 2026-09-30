public interface ITicketService
{
    Task<ApiResponse<bool>> AddTicket(CreateTicketDTO ticketDTO);
    Task<ApiResponse<List<TicketDTO>>> GetTickets();
}