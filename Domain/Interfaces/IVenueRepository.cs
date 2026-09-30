public interface IVenueRepository
{
    Task<bool> AddVenueAsync(Venue venue);
    Task<List<Venue>> GetVenuesAsync();
    Task<bool> DeleteVenueAsync(int id);   
}