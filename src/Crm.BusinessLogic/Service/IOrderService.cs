using Crm.DataAccess;
namespace Crm.BusinessLogic;

public interface IOrderService
{
    ValueTask<bool> CreateAsync(Order order, CancellationToken cancellationToken);
    ValueTask<bool> GetOrder(long orderId);
    ValueTask<bool> DeleteOrderAsync(long orderId);
    ValueTask<bool> UpdateOrderStateAsync(long orderId, OrderState newOrderState);
}