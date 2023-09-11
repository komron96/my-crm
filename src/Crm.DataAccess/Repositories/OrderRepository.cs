namespace Crm.DataAccess;

public sealed class OrderRepository : IOrderRepository
{
    private readonly List<Order> _orders;
    private long _id = 0;

    public OrderRepository()
    {
        _orders = new List<Order>();
    }


    public bool Create(Order order)
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
        _orders.Add(newOrder);
        return orderinfo with { Id = newOrder.Id };
    }

    public bool GetOrder(long orderId)
    {
        Order order = _orders.Find(item => item.Id == orderId);
        return order.ToOrderInfo();
    }

    public bool DeleteOrder(long orderId)
    {
        int clientIndex = _orders.FindIndex(item => item.Id == orderId);
        if (clientIndex < 0)
            return false;
        _orders.RemoveAt(clientIndex);
        return true;
    }

    public bool UpdateOrderState(long orderId, OrderState newOrderState)
    {
        Order? order = _orders.Find(item => item.Id == orderId);
        if (order is null) return false;
        order.OrderState = newOrderState;
        return true;
    }


    //Counts
    public int OrderCount() => _orders.Count;

    public int OrderStateCount(OrderState orderState) => _orders.Count(item => item.OrderState == orderState);
}
