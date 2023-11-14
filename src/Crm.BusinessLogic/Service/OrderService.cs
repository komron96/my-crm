using Crm.DataAccess;
namespace Crm.BusinessLogic;
public sealed class OrderService : IOrderService
{  
    public readonly IOrderRepository _orderRepository;
    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public ValueTask<bool> CreateAsync(Order order, CancellationToken cancellationToken)
    {

        return _orderRepository.CreateOrderAsync(order.ToOrderInfo(), cancellationToken);
    }

    public ValueTask<bool> GetOrderAsync(long orderId, CancellationToken cancellationToken)
    {
        return _orderRepository.GetOrderAsync(orderId, cancellationToken);
    }


    public ValueTask<bool> DeleteOrderAsync(long orderId, CancellationToken cancellationToken)
    {
        return _orderRepository.DeleteOrderAsync(orderId,cancellationToken);
    }

    public ValueTask<bool> UpdateOrderStateAsync(long orderId, OrderState newOrderState)
    {
        return _orderRepository.UpdateOrderStateAsync(orderId, newOrderState);
    }
}
