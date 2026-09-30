using Microsoft.AspNetCore.Mvc;

namespace Webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VenueController(IVenueService venueService) : ControllerBase
{
    private IVenueService service = venueService;
    [HttpPost]
    public async Task<ApiResponse<bool>> AddVenue(CreateVenueDTO venueDTO)
    {
        return await service.AddVenue(venueDTO);
    }
    [HttpDelete("{id:int}")]
    public async Task<ApiResponse<bool>> DeleteVenue(int id)
    {
        return await service.DeleteVenue(id);
    }
    [HttpGet]
    public async Task<ApiResponse<List<VenueDTO>>> GetVenues()
    {
        return await service.GetVenues();
    }
}
