using Crm.DataAccess;
namespace Crm.BusinessLogic;
public sealed class OrderService : IOrderService
{  
    public readonly IOrderRepository _orderRepository;
    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }



    public OrderInfo CreateOrder(OrderInfo orderinfo)
    {
        Order newOrder = new()
            {
                Id = _id++,
                Description = orderinfo.Description,
                Price = orderinfo.Price,
                Date = orderinfo.Date,
                Delivery = orderinfo.Delivery,
                Address = orderinfo.Address,
                OrderState = orderinfo.OrderState.ToOrderStateEnum(),
            };

        _ordersList.Add(newOrder);
        return orderinfo with { Id = newOrder.Id};
    }

    public OrderInfo GetOrder(string OrderId)
    {
        if(OrderId is not {Length: > 0})
            throw new ArgumentException(nameof(OrderId));

        Order order = _ordersList.Find(item => item.Id.Equals(OrderId));
            return order.ToOrderInfo();
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
