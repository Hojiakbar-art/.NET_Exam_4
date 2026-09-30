using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class CategoryRepository(AppDbContext appDbContext) : ICategoryRepository
{
    private AppDbContext context=appDbContext;
    public async Task<List<Category>> GetCategoriesAsync()
    {
        return await context.Categories.Include(x=>x.Events).ToListAsync();
    }

}
