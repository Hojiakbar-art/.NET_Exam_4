using System.ComponentModel.DataAnnotations;



public class Category
{
    public int Id{get;set;}
    
    [Required]
    [MaxLength(100)]
    public string Name{get;set;} = null!;

    public ICollection<Event> Events {get;set;} = [];
}