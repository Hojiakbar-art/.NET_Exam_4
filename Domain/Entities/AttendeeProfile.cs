using System.ComponentModel.DataAnnotations;



public class AttendeeProfile
{
    public int Id{get;set;}
    public int AttendeeId {get;set;}
    public DateTime? DateOfBirth {get;set;}

    [MaxLength(100)]
    public string? City {get;set;}

    [MaxLength(100)]
    public string? Bio {get;set;}

    public Attendee Attendee {get;set;} = null!;
}