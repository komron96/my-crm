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



    public bool Create(Order order)
    {
        return _orderRepository.Create(order);
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
