namespace Domain.Interfaces;

public interface ICategoryRepository
{
    Task<List<Category>> GetCategoriesAsync(); 
}
