using Crm.DataAccess;
namespace Crm.BusinessLogic;

public interface IClientService
{
    bool Create(Client cleint);
    bool GetClient(string firstName, string lastName);
    bool DeleteClient(long clientid);
    bool EditClient(long clientId, string NewFirstName, string NewLastName);
}


public interface IOrderService
{
    ValueTask<bool> CreateAsync(Order order, CancellationToken cancellationToken);
    ValueTask<bool> GetOrderAsync(long orderId, CancellationToken cancellationToken);
    ValueTask<bool> DeleteOrderAsync(long orderId, CancellationToken cancellationToken);
    ValueTask<bool> UpdateOrderStateAsync(long orderId, OrderState newOrderState);
}