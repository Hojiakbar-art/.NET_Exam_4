public interface IAttendeeRepository
{
    Task<bool> AddAttendeeAsync(Attendee attendee);
    Task<bool> UpdateAttendeeAsync(Attendee attendee);
    Task<bool> DeleteAttendeeAsync(int id);
    Task<Attendee> GetAttendeebyIdAsync(int id);
    Task<List<Attendee>> GetAttendeesAsync();
}