using Microsoft.EntityFrameworkCore;

namespace Crm.DataAccess;

public sealed class EFCoreOrderRepository : IOrderRepository
{
    private readonly CrmDbContex _db;

    //Конструктор
    public EFCoreOrderRepository(CrmDbContex crmDbContex)
    {
        _db = crmDbContex;
    }

    public async ValueTask<bool> CreateOrderAsync(Order order, CancellationToken cancellationToken = default)
    {
        await _db.Orders.AddAsync(order, cancellationToken);
        return await _db.SaveChangesAsync(cancellationToken) > 0; 
        //В данном случае мы через ретёрн метода SaveChangesAsync проверяем есть ли измнения больше 0, если есть то сохраняем данные в бд
    }

    public ValueTask<bool> DeleteOrderAsync(long orderId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> GetOrderAsync(long OrderId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> GetOrderCountAsync(CancellationToken cancellationToken = default)
    {
        return new (_db.Orders.CountAsync(cancellationToken));
    }

    public ValueTask<int> GetOrderStateCountAsync(OrderState orderState, CancellationToken cancellationToken = default)
    {
        return new(_db.Orders.CountAsync(p => p.OrderState == orderState, cancellationToken));
    }

    public async ValueTask<bool> UpdateOrderStateAsync(long orderId, OrderState orderstate, CancellationToken cancellationToken = default)
    {
        Order order = await _db.Orders.SingleAsync(o => o.Id == orderId, cancellationToken);
        order.OrderState = orderstate;

        _db.Update(order);
        return await _db.SaveChangesAsync(cancellationToken) > 0;
    }
}