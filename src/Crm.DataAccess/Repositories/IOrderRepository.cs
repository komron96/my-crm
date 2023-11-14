namespace Crm.DataAccess;
public interface IOrderRepository
{
    ValueTask<bool> CreateOrderAsync(Order order, CancellationToken cancellationToken = default);
    ValueTask<bool> GetOrderAsync(long OrderId, CancellationToken cancellationToken = default);
    ValueTask<bool> DeleteOrderAsync(long orderId, CancellationToken cancellationToken = default);
    ValueTask<bool> UpdateOrderStateAsync(long orderId, OrderState orderstate, CancellationToken cancellationToken = default);

    ValueTask<int> GetOrderCountAsync(CancellationToken cancellationToken = default);
    ValueTask<int> GetOrderStateCountAsync(OrderState orderState, CancellationToken cancellationToken = default);
    ValueTask<bool> CreateOrderAsync(OrderInfo orderInfo, CancellationToken cancellationToken);
}

