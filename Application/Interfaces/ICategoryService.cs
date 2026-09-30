namespace Application.Interfaces;

public interface ICategoryService
{
    Task<ApiResponse<List<CategoryDTO>>> GetCategories();
}
