namespace Crm.DataAccess;
public interface IOrderRepository

{
    bool Create(Order order);
    bool GetOrder(string OrderId);
    bool UpdateOrderState(long orderId, OrderState orderstate);
    bool DeleteOrder(long orderId);


    int GetOrderCount();
    int GetOrderStateCount(OrderState orderState);
}

