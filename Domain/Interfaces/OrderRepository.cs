public interface IOrderRepository
{
    Task<bool> AddOrderAsync(Order order);
    Task<bool> AddOrderPayment(Order order);
    Task<Order?> GetOrderByIdAsync(int id);
}