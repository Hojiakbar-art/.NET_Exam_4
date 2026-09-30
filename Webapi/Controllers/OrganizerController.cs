using Microsoft.AspNetCore.Mvc;

namespace Webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrganizerController(IOrganizerService organizerService) : ControllerBase
{
    private IOrganizerService service=organizerService;
    [HttpPost]
    public async Task<ApiResponse<bool>> AddOrganizer(CreateOrganizerDTO createOrganizerDTO)
    {
        return await service.AddOrganizer(createOrganizerDTO);
    }
    [HttpGet]
    public async Task<ApiResponse<List<OrganizerDTO>>> GetOrganizers()
    {
        return await service.GetOrganizers();
    }
    [HttpGet("{id:int}")]
    public async Task<ApiResponse<OrganizerDTO>> GetOrganizerById(int id)
    {
        return await service.GetOrganizerById(id);
    }
}
