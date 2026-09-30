using Microsoft.EntityFrameworkCore;

public class OrderRepository(AppDbContext appDbContext) : IOrderRepository
{
    private AppDbContext context=appDbContext;

    public async Task<bool> AddOrderAsync(Order order)
    {
        context.Orders.Add(order);
        var res=await context.SaveChangesAsync();
        return res>0;
    }

    public async Task<bool> AddOrderPayment(Order order)
    {
        var ord=await context.Orders.FindAsync(order.Id);
        if (ord == null)
        {
            return false;
        }
        ord.TotalAmount=order.TotalAmount;
        var res=await context.SaveChangesAsync();
        return res>0;
    }

    public async Task<Order?> GetOrderByIdAsync(int id)
    {
        return await context.Orders.SingleOrDefaultAsync(x=>x.Id==id);
    }
}