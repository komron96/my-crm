using Crm.DataAccess;
namespace Crm.BusinessLogic;


public sealed class ClientService : IClientService
{
        //Инициализация объектов класса должна происходить в конструкторе, а удаление в деструкторах.
    private readonly List<Client> _clientsList;
    private long _id = 0;
    public ClientService() 
    {
        _clientsList = new();
    }
    

    //Здесь создаём методом клиента CreateClient()
    public ClientInfo CreateClient(ClientInfo clientInfo)
    {
        Client newClient = new()
        
            {
                Id = _id++,
                FirstName = clientInfo.FirstName,
                LastName = clientInfo.LastName,
                MiddleName = clientInfo.MiddleName,
                Age = clientInfo.Age,
                PassportNumber = clientInfo.PassportNumber,
                Email = clientInfo.Email,
                Phone = clientInfo.Phone,
                Password = clientInfo.Password,
                Gender = clientInfo.Gender.TogenderEnum(),
            };

    return clientInfo with {Id = newClient.Id};
    }

    //Method of Getting Client by Fname and Lname
    public Client GetClient(string firstName, string lastName)
    {
        if (firstName is not {Length: > 0})
            throw new ArgumentNullException(nameof(firstName));
        if (lastName is not {Length: > 0})
            throw new ArgumentNullException(nameof(lastName));

        Client? client = _clientsList.Find(item => item.FirstName.Equals(firstName) && item.LastName.Equals(lastName));
        if(client is null)
        {
            throw new NotFoundClietn
        }
    }

    //Method of Deleting Client by id
        public bool DeleteClient(long clientid)
    {
        int clientIndex = _clientsList.FindIndex(item => item.FirstName.Equals(clientid)); //item - переменная перебора цикла
        if (clientIndex < 0)
            return false;

        _clientsList.RemoveAt(clientIndex);
        
        return true;
    }

}



//Создание абстракции ордера и на его основе создание класса ClientOrderd

public class ClientOrder : IOrderService
{  
    //Создание списка ордеров и метод который добавляет в список новый ордер
    private readonly List<Order> _ordersList;
    private readonly List<Order> _orderStateList;
    public ClientOrder() 
    {
        _ordersList = new();
    }

    public Order CreateOrder(
    string Id,
    string descpition,
    string price,
    short date,
    string delivery,
    string address,
    OrderState orderState)
    {
        Order newOrder = new()
    {
        Id = Id,
        Description = descpition,
        Price = price,
        Date = date,
        Delivery = delivery,
        Address = address,
        OrderState = orderState
        
    };
        _ordersList.Add(newOrder);
        _orderStateList.Add(newOrder);;
         return newOrder;
    }


    public Order GetOrder(string OrderId)
    {
        if(OrderId is not {Length: > 0})
            throw new ArgumentException(nameof(OrderId));

        foreach (Order order in _ordersList)
        {
            if(order.Id.Equals(OrderId))
                return order;
        }
        throw new Exception ("Order was not found");
    }

    //Method of Deleting Order
        public bool DeleteOrder(long orderid)
    {
        foreach(Order item in _ordersList)
        {
            if (item.Id.Equals(orderid))
                {
                    _ordersList.Remove(item);
                    return true;
                }
        }   
        return false;
    }

        public int CountOrder()
    {   
        int count = 0;
        foreach(Order item in _ordersList)
        {
            count++; 
        }
        return count;
    }

    //Counting OrderStates
    public bool CountOrderStatus(int CountApproved,int CountPending,int CountCancelled)
    {
            CountApproved = 0;
            CountPending = 0;
            CountCancelled = 0;
        foreach(Order item in _orderStateList)
        {
            switch (item.OrderState)
            {
            case OrderState.Approved:
                CountApproved++;
                break;
            case OrderState.Pending:
                CountPending++;
                break;
            case OrderState.Cancelled:
                CountCancelled++;
                break;
        }
        }
        return true;
    }

    //Method for changing Order Status - недописанный метод
    public bool ChangeOrderStatus(OrderState newOrderStatus, long Id)
    {   
        foreach(Order Order1 in _ordersList)
        {  
            if(Order1.Id.Equals(Id))
            {
                Order1.OrderState = newOrderStatus;
            }
            return true;
        }

        return false;
    }
}
