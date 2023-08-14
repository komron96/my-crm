using Data.Access;
namespace Crm.BusinessLogic;

public interface IClientService
{   
    public Client CreateClient(
    string firstName, string lastName, string middleName,
    short age,
    string passportnumber, 
    string email,
    string phone,
    string password,
    Gender gender);
    public Client? GetClient(string firstName, string lastName);
}


public interface IOrderService
{   
    public Order CreateOrder(
    string ID,
    string Description,
    string Price,
    short Data,
    string Delivery,
    string Adress
);
    public Order? GetOrder(string ID);
}