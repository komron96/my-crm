using Crm.DataAccess;
namespace Crm.BusinessLogic;

public static class StateExtestion
{
    public static OrderState ToOrderStateEnum(this string orderstateStr)
        => Enum.Parse<OrderState>(orderstateStr);


}


public static class OrderExtention
{
    public static OrderInfo ToOrderInfo(this Order order)
    {
        return new(
            order.Id,
            order.Price,
            order.OrderState.ToString(),
            order.Description,
            order.Date,
            order.Address,
            order.DeliveryId);
    }
}