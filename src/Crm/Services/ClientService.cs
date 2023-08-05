using Crm.Entities;
namespace Crm.Services;

public abstract class AbstractClientService
{   
    protected List<Client> ClientsList = new List<Client>();
    public abstract Client CreateClient(ClientInfo clientInfo);
    public abstract void AddClient(ClientInfo clientInfo);
    public abstract void ClientSearch(string firstName, string lastName);
}


public class ClientService : AbstractClientService
{
    public override Client CreateClient(ClientInfo clientInfo)
    {
        return new()
        {
            FirstName = clientInfo.FirstName,
            LastName = clientInfo.LastName,
            MiddleName = clientInfo.MiddleName,
            Age = clientInfo.Age,
            PassportNumber = clientInfo.PassportNumber,
            Gender = clientInfo.Gender,
            Email = clientInfo.Email,
            Phone = clientInfo.Phone,
            Password = clientInfo.Password

        };
    }
    
    List<Client> ClientsList = new List<Client>();
    public override void AddClient(ClientInfo clientInfo)
    {
         Client newClient = CreateClient(clientInfo);
            ClientsList.Add(newClient);   
    }


    public override void ClientSearch(string firstName, string lastName)
    {
        ClientsList.Find(client => client.FirstName == firstName && client.LastName == lastName);
    }
}





//Создание абстракции ордера и на его основе создание класса ClientOrder
public abstract class AbstractOrderService
{   
    protected List<Order> OrderList = new List<Order>();
    public abstract Order CreateOrder(OrderInfo orderInfo);
    public abstract void Addorder(OrderInfo orderInfo);
    public abstract void OrderSearch(string ID);
}

public class ClientOrder : AbstractOrderService
{
    public override Order CreateOrder(OrderInfo orderInfo)
    {
        // TODO: Validate input parameters.
        return new()
        {
            ID = orderInfo.orderID,
            Description = orderInfo.Description,
            Price = orderInfo.Price,
            Date = orderInfo.Date,
            Delivery = orderInfo.Delivery,
            Adress = orderInfo.Adress
        };
    }

    //Создание списка ордеров и метод который добавляет в список новый ордер
    List<Order> OrderList = new List<Order>();

    public override void Addorder(OrderInfo clientInfo)
    {
         Order newOrder = CreateOrder(clientInfo);
            OrderList.Add(newOrder);   
    }

    public Order OrderSearch(string ID)
        {
            return OrderList.Find(order => order.ID == ID);
        }
}