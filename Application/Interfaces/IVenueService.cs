public interface IVenueService
{
    Task<ApiResponse<bool>> AddVenue(CreateVenueDTO venue);
    Task<ApiResponse<bool>> DeleteVenue(int id);
    Task<ApiResponse<List<VenueDTO>>> GetVenues();
}