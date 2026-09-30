using Microsoft.AspNetCore.Mvc;

namespace Webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController(IOrderService orderService) : ControllerBase
{
    private IOrderService service=orderService;
    [HttpPost]
    public async Task<ApiResponse<bool>> AddOrder(CreateOrderDTO orderDTO)
    {
        return await service.AddOrder(orderDTO);
    }
    [HttpPatch]
    public async Task<ApiResponse<bool>> AddOrderPayment([FromQuery]PaymentOrderDTO orderDTO)
    {
        return await service.AddPayment(orderDTO);
    }
    [HttpGet("{id:int}")]
    public async Task<ApiResponse<OrderDTO>> GetOrderById(int id)
    {
        return await service.GetOrderById(id);
    }
}
