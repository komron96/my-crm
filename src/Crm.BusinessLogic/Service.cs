using System.ComponentModel.DataAnnotations;
using Crm.DataAccess;
namespace Crm.BusinessLogic;

public sealed class ClientService : IClientService
{
        //Инициализация объектов класса должна происходить в конструкторе, а удаление в деструкторах.
    private readonly List<Client> _clientsList;
    public ClientService() 
    {
        _clientsList = new();
    }

    //Здесь создаём методом клиента CreateClient()
    public Client CreateClient(
    long ClientID,
    string firstName, string lastName, string middleName,
    short age,
    string passportnumber, 
    string email,
    string phone,
    string password,
    Gender gender)
    {
        Client newClient = new()
    {
        ClientID = ClientID,
        FirstName = firstName,
        LastName = lastName,
        MiddleName = middleName,
        Age = age,
        PassportNumber = passportnumber,
        Email = email,
        Phone = phone,
        Password = password,
        Gender = gender
    };

    _clientsList.Add(newClient);
    return newClient;
    }


    // public void AddClient(ClientInfo clientInfo)
    // {
    //      Client newClient = CreateClient(clientInfo);
    //         _clientsList.Add(newClient);   
    // }

        // Мой метод
    // public void GetClient(string firstName, string lastName)
    // {
    //     _clientsList.Find(client => client.FirstName == firstName && client.LastName == lastName);
    // }


    //Method of Getting Client by Fname and Lname
    public Client GetClient(string firstName, string lastName)
    {
        if (firstName is not {Length: > 0})
            throw new ArgumentNullException(nameof(firstName));
        if (lastName is not {Length: > 0})
            throw new ArgumentNullException(nameof(lastName));

        foreach(Client client in _clientsList)
        {
            if (client.FirstName.Equals(firstName) && client.LastName.Equals(lastName))
                return client;
        }
        throw new Exception ("Client was not found");
    }

    //Method of Deleting Client
        public Client DeleteClient(string clientid)
    {
        foreach(Client client in _clientsList)
        {
            if (client.ClientID.Equals(clientid))
                _clientsList.Remove(clientid);
        }
        throw new Exception ("Client was not found");
    }

}





//Создание абстракции ордера и на его основе создание класса ClientOrderd

public class ClientOrder : IOrderService
{  
    //Создание списка ордеров и метод который добавляет в список новый ордер
    private readonly List<Order> _ordersList;
    public ClientOrder() 
    {
        _ordersList = new();
    }

    public Order CreateOrder(
    string OrderID,
    string descpition,
    string price,
    short date,
    string delivery,
    string adress)
    {
        Order newOrder = new()
    {
        OrderID = OrderID,
        Description = descpition,
        Price = price,
        Date = date,
        Delivery = delivery,
        Adress = adress
    };
        _ordersList.Add(newOrder);
         return newOrder;
    }


    public Order GetOrder(string ID)
    {
        if(ID is not {Length: > 0})
        throw new ArgumentException(nameof(ID));
        foreach (Order order in _ordersList)
        {
            if(order.OrderID.Equals(ID))
                return order;
        }
        throw new Exception ("Order was not found");
    }

    public Order DeleteOrder(string orderid)
    {
        foreach(Order order in _ordersList)
        {
            if (order.OrderID.Equals(orderid))
                _ordersList.Remove(orderid);
        }
        throw new Exception ("Client was not found");

    }
}
