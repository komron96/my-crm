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
    Task<bool> CreateAsync(Order order, CancellationToken cancellationToken);
    bool GetOrder(long orderId);
    bool DeleteOrder(long orderId);
    bool UpdateOrderState(long orderId, OrderState newOrderState);
}