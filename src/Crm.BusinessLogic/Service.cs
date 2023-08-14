using Data.Access;
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


    public void AddClient(ClientInfo clientInfo)
    {
         Client newClient = CreateClient(clientInfo);
            _clientsList.Add(newClient);   
    }

        // Мой метод
    // public void GetClient(string firstName, string lastName)
    // {
    //     _clientsList.Find(client => client.FirstName == firstName && client.LastName == lastName);
    // }
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
    string id,
    string descpition,
    string price,
    short date,
    string delivery,
    string adress)
    {
        Order newOrder = new()
    {
        ID = id,
        Description = descpition,
        Price = price,
        Date = date,
        Delivery = delivery,
        Adress = adress
    };
        _ordersList.Add(newOrder);
         return newOrder;
    }


    public Client GetOrder(string id)
    {
        if (id is not {Length: > 0})
            throw new ArgumentNullException(nameof(id));

        foreach(Order order in _ordersList)
        {
            if (order.ID.Equals(id) )
                return order;
        }
        throw new Exception ("Order was not found");
    }
}
