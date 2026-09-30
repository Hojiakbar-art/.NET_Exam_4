using System;
using Application.Interfaces;
using Domain.Interfaces;
    

namespace Application.Services;

public class CategoryService(ICategoryRepository categoryRepository):ICategoryService
{
    private ICategoryRepository repository=categoryRepository;

    public async Task<ApiResponse<List<CategoryDTO>>> GetCategories()
    {
        var data=await repository.GetCategoriesAsync();
        List<CategoryDTO> categoryDTOs=new();
        foreach (var item in data)
        {
            var dt=new CategoryDTO()
            {
                Name=item.Name  
            };
            categoryDTOs.Add(dt);
        }
        return new ApiResponse<List<CategoryDTO>>(System.Net.HttpStatusCode.OK, "The list of categories: ", categoryDTOs);
    }



}
