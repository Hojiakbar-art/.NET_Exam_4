using System.Net;
using Microsoft.AspNetCore.DataProtection.Repositories;
public class AttendeeService(IAttendeeRepository attendeeRepository) : IAttendeeService
{
    private IAttendeeRepository repository=attendeeRepository;

    public async Task<ApiResponse<bool>> AddAttendee(CreateAttendeeDTO createAttendeeDTO)
    {
        var att=new Attendee()
        {
            FullName=createAttendeeDTO.FullName,
            Email=createAttendeeDTO.Email  
        };
        var res=await repository.AddAttendeeAsync(att);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Added", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "something went wrong!", res);
        
    }

    public async Task<ApiResponse<bool>> DeleteAttendee(int id)
    {
        var res=await repository.DeleteAttendeeAsync(id);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "deleted", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "something went wrong!", res);
    }

    public async Task<ApiResponse<Attendee>> GetAttendeebyId(int id)
    {
        var data=await repository.GetAttendeebyIdAsync(id);
        var att=new Attendee()
        {   
            FullName=data.FullName,
            Email=data.Email
        };
        return new ApiResponse<Attendee>(HttpStatusCode.OK, "The attendee by id", att);
    }

    public async Task<ApiResponse<List<Attendee>>> GetAttendees()
    {
        List<Attendee> attendeeDTOs=new();
        
        var data=await repository.GetAttendeesAsync();
        foreach (var item in data)
        {
            var att=new Attendee()
            {
                FullName=item.FullName,
                Email=item.Email
            };
            attendeeDTOs.Add(att);
        }
        return new ApiResponse<List<Attendee>>(HttpStatusCode.OK, "The list of attendees: ", attendeeDTOs);
    }

    public async Task<ApiResponse<bool>> UpdateAttendee(UpdateAttendeeDTO updateAttendeeDTO)
    {
        var att=new Attendee()
        {
            Id=updateAttendeeDTO.Id,
            FullName=updateAttendeeDTO.FullName,
            Email=updateAttendeeDTO.Email  
        };
        var res=await repository.UpdateAttendeeAsync(att);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Updated", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "something went wrong!", res);
    }
}