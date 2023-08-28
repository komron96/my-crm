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
    public Order CreateOrder();
    public Order? GetOrder(string ID);
    public bool DeleteOrder(long orderid);
    public bool CountOrderStatus(int CountApproved,int CountPending,int CountCancelled);
    public bool ChangeOrderStatus(OrderState newOrderStatus, long Id);
    
}