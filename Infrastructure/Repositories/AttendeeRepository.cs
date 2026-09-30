using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class AttendeeRepository(AppDbContext appDbContext):IAttendeeRepository
{
    private AppDbContext context=appDbContext;

    public async Task<bool> AddAttendeeAsync(Attendee attendee)
    {
        context.Attendees.Add(attendee);
        var res=await context.SaveChangesAsync();
        return res>0;
    }

    public async Task<bool> DeleteAttendeeAsync(int id)
    {
        var at=await context.Attendees.FindAsync(id);
        if (at == null)
        {
            return false;
        }
        context.Attendees.Remove(at);
        var res=await context.SaveChangesAsync();
        return res>0;

    }

    public async Task<Attendee> GetAttendeebyIdAsync(int id)
    {
        return await context.Attendees.SingleOrDefaultAsync(x=>x.Id==id);
    }

    public async Task<List<Attendee>> GetAttendeesAsync()
    {
        return await context.Attendees.ToListAsync();
    }

    public async Task<bool> UpdateAttendeeAsync(Attendee attendee)
    {
        var at=await context.Attendees.FindAsync(attendee.Id);
        if (at == null)
        {
            return false;
        }
        at.FullName=attendee.FullName;
        at.Email=attendee.Email;
        var res=await context.SaveChangesAsync();
        return res>0;
    }

}

