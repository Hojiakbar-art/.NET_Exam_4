public interface IOrganizerService
{
    Task<ApiResponse<bool>> AddOrganizer(CreateOrganizerDTO createOrganizerDTO);
    Task<ApiResponse<List<OrganizerDTO>>> GetOrganizers();
    Task<ApiResponse<OrganizerDTO>> GetOrganizerById(int id); 
}