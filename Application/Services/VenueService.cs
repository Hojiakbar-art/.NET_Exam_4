public class VenueService(IVenueRepository venueRepository) : IVenueService
{
    private IVenueRepository repository=venueRepository;

    public async Task<ApiResponse<bool>> AddVenue(CreateVenueDTO venue)
    {
        var ven=new Venue()
        {
            Name=venue.Name,
            Address=venue.Address,
            City=venue.City,
            Capacity=venue.Capacity  
        };
        var res=await repository.AddVenueAsync(ven);
        return res==true
        ? new ApiResponse<bool>(System.Net.HttpStatusCode.OK, "Added", res)
        : new ApiResponse<bool>(System.Net.HttpStatusCode.InternalServerError, "something went wrong!", res);
    }

    public async Task<ApiResponse<bool>> DeleteVenue(int id)
    {
        var res=await repository.DeleteVenueAsync(id);
        return res==true
        ? new ApiResponse<bool>(System.Net.HttpStatusCode.OK, "deleted", res)
        : new ApiResponse<bool>(System.Net.HttpStatusCode.InternalServerError, "something went wrong!", res);
    }

    public async Task<ApiResponse<List<VenueDTO>>> GetVenues()
    {
        var data=await repository.GetVenuesAsync();
        List<VenueDTO> venueDTOs=new();
        foreach (var item in data)
        {
            var ven=new VenueDTO()
            {
                Name=item.Name,
                Address=item.Address,
                Capacity=item.Capacity,
                City=item.City  
            };
            venueDTOs.Add(ven);
        }
        return new ApiResponse<List<VenueDTO>>(System.Net.HttpStatusCode.OK,"The list of Venues: ", venueDTOs);
    }
}