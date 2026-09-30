using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController(ICategoryService categoryService) : ControllerBase
{
    private ICategoryService service=categoryService;
    [HttpGet]
    public async Task<ApiResponse<List<CategoryDTO>>> GetCategories()
    {
        return await service.GetCategories();
    }
}
