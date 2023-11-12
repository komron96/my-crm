using Crm.BusinessLogic;
using Crm.DataAccess;
using Microsoft.AspNetCore.Mvc;
namespace Crm.Web;

[ApiController]
[Route("api/v1/orders")]
public sealed class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public ValueTask<bool> CreateAsync([FromBody] Order order, CancellationToken cancellationToken)
    {
        return _orderService.CreateAsync(order, cancellationToken);
    }

    [HttpGet("get")]
    public ValueTask<bool> GetOrder([FromQuery] long orderId)
    {
        return _orderService.GetOrder(orderId);
    }


    [HttpGet("get")]
    public ValueTask<bool> DeleteOrderAsync(long orderId)
    {
        return _orderService.DeleteOrderAsync(orderId);
    }



}


