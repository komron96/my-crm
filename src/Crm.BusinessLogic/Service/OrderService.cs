using Crm.DataAccess;
namespace Crm.BusinessLogic;
public sealed class OrderService : IOrderService
{  
    //Создание списка ордеров и метод который добавляет в список новый ордер
    private readonly List<Order> _ordersList;
    private long _id = 0;
    public OrderService() 
    {
        _ordersList = new();
    }

    public OrderInfo CreateOrder(OrderInfo orderinfo)
    {
        Order newOrder = new()
            {
                Id = _id++,
                Description = orderinfo.Description,
                Price = orderinfo.Price,
                Date = orderinfo.Date,
                Delivery = orderinfo.Delivery,
                Address = orderinfo.Address,
                OrderState = orderinfo.OrderState.ToOrderStateEnum(),
            };

        _ordersList.Add(newOrder);
        return orderinfo with { Id = newOrder.Id};
    }


    public OrderInfo GetOrder(string OrderId)
    {
        if(OrderId is not {Length: > 0})
            throw new ArgumentException(nameof(OrderId));

        Order order = _ordersList.Find(item => item.Id.Equals(OrderId));
            return order.ToOrderInfo();
    }

    public bool DeleteOrder(long orderid)
    {
        int clientIndex = _ordersList.FindIndex(item => item.Id.Equals(orderid));
        if (clientIndex < 0)
            return false;

        _ordersList.RemoveAt(clientIndex);
        return true;
    }
}
