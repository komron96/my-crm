namespace Crm.DataAccess;
public interface IOrderRepository

{
    bool Create(Order order);
    bool UpdateOrderState(long orderId, OrderState orderstate);
    int GetOrderCount();
    int GetOrderCount(OrderState orderState);
}

