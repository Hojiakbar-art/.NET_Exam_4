using Microsoft.EntityFrameworkCore;

public class TicketRepository(AppDbContext appDbContext) : ITicketRepository
{
    private AppDbContext context=appDbContext;

    public async Task<bool> AddTicketAsync(Ticket ticket)
    {
        context.Tickets.Add(ticket);
        var res=await context.SaveChangesAsync();
        return res>0;
    }

    public async Task<List<Ticket>> GetTicketsAsync()
    {
        return await context.Tickets.Include(x=>x.Order).Include(x=>x.Attendee).Include(x=>x.TicketType).ToListAsync();
    }
}