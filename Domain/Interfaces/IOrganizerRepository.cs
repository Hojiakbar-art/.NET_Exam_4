public interface IOrganizerRepository
{
    Task<bool> AddOrganizerAsync(Organizer organizer);
    Task<List<Organizer>> GetOrganizersAsync();
    Task<Organizer?> GetOrganizerbyIdAsync(int id);
}