namespace Data.Access;
//нужно перенести абстракции в отдельные файлы и сделать депенденси от абстракций(перенести метод createclient и его свойства)
//главный принцип в том что имплимнтация(реализация доречного класса) должна реализовать методы родительского класса.
//нужно будет создать новый модуль который называется businesslogic - там будут клиентсервис а в crm должен быть только файл programm
public abstract class AbstractClientService
{   
    private readonly List<Client> ClientsList;
    public abstract Client CreateClient(ClientInfo clientInfo);
    public abstract void AddClient(ClientInfo clientInfo);
    public abstract void ClientSearch(string firstName, string lastName);
}


public sealed class ClientService : AbstractClientService
{
        //Инициализация объектов класса должна происходить в конструкторе, а удаление в деструкторах.
    private readonly List<Client> _clientsList;// = new List<Client>();
    //Инициализация в конструкторе 
    public ClientService() 
    {
        _clientsList = new();
    }

    public override void AddClient(ClientInfo clientInfo)
    {
         Client newClient = CreateClient(clientInfo);
            _clientsList.Add(newClient);   
    }

    public override string ClientSearch(string firstName, string lastName)
    {
        _clientsList.Find(client => client.FirstName == firstName && client.LastName == lastName);
        

        
         foreach(Client client in _clientsList)
            if(client.FirstName.Equals(firstName) && client.LastName.Equals(lastName))
                return client;

    }

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
    


}






//Создание абстракции ордера и на его основе создание класса ClientOrderd
public abstract class AbstractOrderService
{   
    protected List<Order> OrderList = new List<Order>();
    public abstract Order CreateOrder(OrderInfo orderInfo);
    public abstract void AddOrder(OrderInfo orderInfo);
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

    public override void AddOrder(OrderInfo clientInfo)
    {
         Order newOrder = CreateOrder(clientInfo);
            OrderList.Add(newOrder);   
    }

    public Order OrderSearch(string ID)
        {
            return OrderList.Find(order => order.ID == ID);
        }
}