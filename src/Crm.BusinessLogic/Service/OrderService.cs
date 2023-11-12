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
        return _orderRepository.CreateOrderAsync(order, cancellationToken);
    }

    public ValueTask<bool> GetOrder(long orderId)
    {
        return _orderRepository.GetOrderAsync(orderId);
    }


    public ValueTask<bool> DeleteOrderAsync(long orderId)
    {
        return _orderRepository.DeleteOrderAsync(orderId);
    }

    public ValueTask<bool> UpdateOrderStateAsync(long orderId, OrderState newOrderState)
    {
        return _orderRepository.UpdateOrderStateAsync(orderId, newOrderState);
    }
}
