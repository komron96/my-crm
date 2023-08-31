using Crm.DataAccess;
namespace Crm.BusinessLogic;

public static class ClientInfoExtenstion
    {
        public static ClientInfo ToClientInfo(this Client client) 
        //this обозначает что метод ссылается не на класс а на экземплярм класса
        //Дополнительно во входный параметр в данном случае будет являться client -> client.ToClientInfo(cleint)
        {
            return new(
                client.Id,
                client.FirstName,
                client.LastName,
                client.MiddleName,
                client.Phone,
                client.Email,
                client.Password,
                client.PassportNumber,
                client.Age,
                client.Gender.ToString());
        }
    }

public static class OrderInfoExtenstion
    {
        public static OrderInfo ToOrderInfo(this Order order)
        {
            return new(
                order.Id,
                order.Description,
                order.Price,
                order.Date,
                order.Delivery,
                order.Address,
                order.OrderState.ToString());
        }
    }


