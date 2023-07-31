using Crm.Entities;

namespace Crm.Services;


public sealed class ClientService
{
    public Client CreateClient(ClientInfo clientInfo)
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
    
    List<Client> clients = new List<Client>();
    public void AddClient(ClientInfo clientInfo)
    {
         Client newClient = CreateClient(clientInfo);
            clients.Add(newClient);   
    }


    // public void ListOfClients()
    // {
    //     foreach (string x in clients)
    //     {
    //         Console.WriteLine(x);
    //     }

    // }
}

public sealed class ClientOrder
{
    public Order CreateOrder(OrderInfo orderInfo)
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
}