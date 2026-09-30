using Microsoft.EntityFrameworkCore;

public class VenueRepository(AppDbContext appDbContext) : IVenueRepository
{
    private AppDbContext context=appDbContext;

    public async Task<bool> AddVenueAsync(Venue venue)
    {
        context.Venues.Add(venue);
        var res=await context.SaveChangesAsync();
        return res>0;
    }

    public async Task<bool> DeleteVenueAsync(int id)
    {
        var ven=await context.Venues.FindAsync(id);
        if (ven == null)
        {
            return false;
        }
        context.Remove(ven);
        var res=await context.SaveChangesAsync();
        return res>0;
    }

    public async Task<List<Venue>> GetVenuesAsync()
    {
        return await context.Venues.Include(x=>x.Events).ToListAsync();
    }
}