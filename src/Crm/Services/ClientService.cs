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
            Gender = clientInfo.Gender
        };
    }
}

public sealed class ClientOrders
{
    public Order Createorder(
        string orderID,
        string Description,
        string Price,
        short Date,
        string Delivery,
        string Adress
    )
    {
        // TODO: Validate input parameters.
        return new()
        {
            orderID = orderID,
            Description = Description,
            Price = Price,
            Date = Date,
            Delivery = Delivery,
            Adress = Adress
        };
    }
}