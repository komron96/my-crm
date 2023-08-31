using Crm.DataAccess;
namespace Crm.BusinessLogic;

public interface IClientService
{   
    public ClientInfo CreateClient(ClientInfo clientInfo);
    public ClientInfo GetClient(string firstName, string lastName);
    public bool DeleteClient(long clientid);
}


public interface IOrderService
{   
    public OrderInfo CreateOrder(OrderInfo orderInfo);
    public OrderInfo GetOrder(string ID);
    public bool DeleteOrder(long orderId);
    public bool UpdateOrderState(long orderId, OrderState newOrderState);
}