using System.ComponentModel;
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
    long Id,
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
        Id = Id,
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
        public bool DeleteClient(long clientid)
    {
        foreach(Client item in _clientsList)
        {
            if (item.Id.Equals(clientid))
                {
                    _clientsList.Remove(item);
                    return true;
                }
        }   
        return false;
    }
    
    public int CountClient()
    {   
        int count = 0;
        foreach(Client item in _clientsList)
        {
            count++; 
        }
        return count;
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

    //Method for chaning Order Status - недописанный метод
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
