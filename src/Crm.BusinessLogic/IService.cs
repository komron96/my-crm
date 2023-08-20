using Crm.DataAccess;
namespace Crm.BusinessLogic;

public interface IClientService
{   
    public Client CreateClient(
    long ClientID,
    string firstName, string lastName, string middleName,
    short age,
    string passportnumber, 
    string email,
    string phone,
    string password,
    Gender gender);
    public Client? GetClient(string firstName, string lastName);
    public bool DeleteClient(long clientid);
    public bool CountClient(int count);

}


public interface IOrderService
{   
    public Order CreateOrder(
    string OrderID,
    string Description,
    string Price,
    short Data,
    string Delivery,
    string Adress,
    OrderState orderState
);
    public Order? GetOrder(string ID);
    public bool DeleteOrder(long orderid);
    public bool CountOrder(int count);
    public bool CountOrderStatus(int CountApproved,int CountPending,int CountCancelled);
    // public bool ChangeOrderStatus(Order newOrderStatus);
    
}