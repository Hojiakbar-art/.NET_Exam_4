public interface IAttendeeService
{
    Task<ApiResponse<bool>> AddAttendee(CreateAttendeeDTO createAttendeeDTO);
    Task<ApiResponse<bool>> DeleteAttendee(int id);
    Task<ApiResponse<bool>> UpdateAttendee(UpdateAttendeeDTO updateAttendeeDTO);
    Task<ApiResponse<Attendee>> GetAttendeebyId(int id);
    Task<ApiResponse<List<Attendee>>> GetAttendees();
}