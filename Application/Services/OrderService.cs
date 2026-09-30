using System.Net;

public class OrderService(IOrderRepository orderRepository) : IOrderService
{
    private IOrderRepository repository=orderRepository;

    public async Task<ApiResponse<bool>> AddOrder(CreateOrderDTO orderDTO)
    {
        var ord=new Order()
        {
            AttendeeId=orderDTO.AttendeeId,
            TotalAmount=orderDTO.TotalAmount,
            Status=orderDTO.Status
        };
        var res=await repository.AddOrderAsync(ord);
        return res==true
        ?new ApiResponse<bool>(System.Net.HttpStatusCode.OK, "Added!", res)
        :new ApiResponse<bool>(System.Net.HttpStatusCode.OK, "something went wrong!", res);
    }

    public async Task<ApiResponse<bool>> AddPayment(PaymentOrderDTO orderDTO)
    {
        var ord=new Order()
        {
            Id=orderDTO.Id,
            AttendeeId=orderDTO.AttendeeId,
            TotalAmount=orderDTO.TotalAmount,
            Status=orderDTO.Status
        };
        var res=await repository.AddOrderPayment(ord);
        return res==true
        ? new ApiResponse<bool>(System.Net.HttpStatusCode.OK, "Added payment!", res)
        : new ApiResponse<bool>(System.Net.HttpStatusCode.InternalServerError, "something went wrong!", res);
    }

    public async Task<ApiResponse<OrderDTO>> GetOrderById(int id)
    {
        var data=await repository.GetOrderByIdAsync(id);
        var ord=new OrderDTO()
        {
            AttendeeId=data.AttendeeId,
            TotalAmount=data.TotalAmount,
            Status=data.Status,
            Tickets=data.Tickets
        };
        return new ApiResponse<OrderDTO>(HttpStatusCode.OK, "The order by id: ", ord);
    }
}