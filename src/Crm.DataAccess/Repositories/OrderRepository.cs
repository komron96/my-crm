using Crm.DataAccess;

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
        throw new NotImplementedException();
    }

     public int GetOrderCount() => _orders.Count;

    public int GetOrderStateCount(OrderState orderState) => _orders.Count(o => o.OrderState == orderState);

    public bool UpdateOrderState(long orderId, OrderState newOrderState)
    {
        Order? order = _orders.Find(item => item.Id.Equals(orderId));
        if (order is null) return false;
        order.OrderState = newOrderState;
        return true;
    }  
}