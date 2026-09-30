using Microsoft.EntityFrameworkCore;

public class OrganizerRepository(AppDbContext dbContext) : IOrganizerRepository
{
    private AppDbContext context=dbContext;

    public async Task<bool> AddOrganizerAsync(Organizer organizer)
    {
        context.Organizers.Add(organizer);
        var res=await context.SaveChangesAsync();
        return res>0;
    }

    public async Task<Organizer?> GetOrganizerbyIdAsync(int id)
    {
        return await context.Organizers.Include(x=>x.Events).SingleOrDefaultAsync(x=>x.Id == id);
    }

    public async Task<List<Organizer>> GetOrganizersAsync()
    {
        return await context.Organizers.Include(x=>x.Events).ToListAsync();
    }
}