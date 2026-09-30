using System.ComponentModel.DataAnnotations;


public class CreateOrganizerDTO
{
    public string CompanyName{get;set;} = null!;
    public string ContactEmail{get;set;} = null!;
    public string? Phone{get;set;}
}