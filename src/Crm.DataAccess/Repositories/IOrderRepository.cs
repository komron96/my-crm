namespace Crm.DataAccess;
public interface IOrderRepository
{
    //Main methods of Order
    Task<bool> CreateOrderAsync(Order order, CancellationToken cancellationToken);
    bool GetOrder(long OrderId);
    bool DeleteOrder(long orderId);
    bool UpdateOrderState(long orderId, OrderState orderstate);


    //Stat service
    int OrderCount();
    int OrderStateCount(OrderState orderState);
}

