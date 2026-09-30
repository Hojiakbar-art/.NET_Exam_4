using Microsoft.AspNetCore.Mvc;

namespace Webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AttendeeController(IAttendeeService attendeeService) : ControllerBase
{
    private IAttendeeService service=attendeeService;
    [HttpPost]
    public async Task<ApiResponse<bool>> AddAttendee(CreateAttendeeDTO createAttendeeDTO)
    {
        return await service.AddAttendee(createAttendeeDTO);
    }
    [HttpDelete("{id:int}")]
    public async Task<ApiResponse<bool>> DeleteAttendee(int id)
    {
        return await service.DeleteAttendee(id);
    }
    [HttpGet]
    public async Task<ApiResponse<List<Attendee>>> GetAttendees()
    {
        return await service.GetAttendees();
    }
    [HttpGet("{id:int}")]
    public async Task<ApiResponse<Attendee>> GetAttendeebyId(int id)
    {
        return await service.GetAttendeebyId(id);
    }
    [HttpPut]
    public async Task<ApiResponse<bool>> UpdateAttendee([FromQuery] UpdateAttendeeDTO updateAttendeeDTO)
    {
        return await service.UpdateAttendee(updateAttendeeDTO);
    }

}
