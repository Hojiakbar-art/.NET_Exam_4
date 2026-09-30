public interface IOrderService
{
    Task<ApiResponse<bool>> AddOrder(CreateOrderDTO orderDTO);
    Task<ApiResponse<bool>> AddPayment(PaymentOrderDTO orderDTO);
    Task<ApiResponse<OrderDTO>> GetOrderById(int id);
}