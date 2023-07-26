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

public sealed class ClientOrder
{
    public Order CreateOrder(OrderInfo orderInfo)
    {
        // TODO: Validate input parameters.
        return new()
        {
            orderID = orderInfo.orderID,
            Description = orderInfo.Description,
            Price = orderInfo.Price,
            Date = orderInfo.Date,
            Delivery = orderInfo.Delivery,
            Adress = orderInfo.Adress
        };
    }
}