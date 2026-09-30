public class OrganizerService(IOrganizerRepository organizerRepository) : IOrganizerService
{
    private IOrganizerRepository repository=organizerRepository;

    public async Task<ApiResponse<bool>> AddOrganizer(CreateOrganizerDTO createOrganizerDTO)
    {
        var org=new Organizer()
        {
            CompanyName=createOrganizerDTO.CompanyName,
            ContactEmail=createOrganizerDTO.ContactEmail,
            Phone=createOrganizerDTO.Phone  
        };
        var res=await repository.AddOrganizerAsync(org);
        return res==true
        ? new ApiResponse<bool>(System.Net.HttpStatusCode.OK, "Added", res)
        : new ApiResponse<bool>(System.Net.HttpStatusCode.InternalServerError, "something went wrong!", res);
    }

    public async Task<ApiResponse<OrganizerDTO>> GetOrganizerById(int id)
    {
        var data=await repository.GetOrganizerbyIdAsync(id);
        var org=new OrganizerDTO()
        {
            CompanyName=data.CompanyName,
            ContactEmail=data.ContactEmail,
            Phone=data.Phone  
        };
        return new ApiResponse<OrganizerDTO>(System.Net.HttpStatusCode.OK, "The organizer by id: ", org);
        
    }

    public async Task<ApiResponse<List<OrganizerDTO>>> GetOrganizers()
    {
        var data=await repository.GetOrganizersAsync();
        List<OrganizerDTO> organizerDTOs=new List<OrganizerDTO>();
        foreach (var item in data)
        {
            var org=new OrganizerDTO()
            {
                CompanyName=item.CompanyName,
                ContactEmail=item.ContactEmail,
                Phone=item.Phone  
            };
            organizerDTOs.Add(org);
        }
        return new ApiResponse<List<OrganizerDTO>>(System.Net.HttpStatusCode.OK, "The list of Organizers: ", organizerDTOs);
    }
}