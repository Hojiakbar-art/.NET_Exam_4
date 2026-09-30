using Microsoft.AspNetCore.Mvc;

namespace Webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TicketController(ITicketService ticketService) : ControllerBase
{
    private ITicketService service=ticketService;
    [HttpPost]
    public async Task<ApiResponse<bool>> AddTicket(CreateTicketDTO createTicketDTO)
    {
        return await service.AddTicket(createTicketDTO);
    }
    [HttpGet]
    public async Task<ApiResponse<List<TicketDTO>>> GetTickets()
    {
        return await service.GetTickets();
    }
}
