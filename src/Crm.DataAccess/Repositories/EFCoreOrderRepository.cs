namespace Crm.DataAccess;

public sealed class PosgresqlOrderRepository : IOrderRepository
{
    public ValueTask<bool> CreateOrderAsync(Order order, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteOrderAsync(long orderId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> GetOrderAsync(long OrderId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> GetOrderAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> GetOrderStateCountAsync(OrderState orderState, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> UpdateOrderStateAsync(long orderId, OrderState orderstate, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}