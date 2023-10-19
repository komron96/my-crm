using Crm.DataAccess;
namespace Crm.BusinessLogic;
public sealed class OrderService : IOrderService
{  
    public readonly IOrderRepository _orderRepository;
    //Question - почему мы обращаемся к репозиторию
    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }



    public Task<bool> CreateAsync(Order order, CancellationToken cancellationToken)
    {
        return _orderRepository.CreateAsync(order, cancellationToken);
    }

    public bool GetOrder(long orderId)
    {
        return _orderRepository.GetOrder(orderId);
    }


    public bool DeleteOrder(long orderId)
    {
        return _orderRepository.DeleteOrder(orderId);
    }

    public bool UpdateOrderState(long orderId, OrderState newOrderState)
    {
        return _orderRepository.UpdateOrderState(orderId, newOrderState);
    }
}
