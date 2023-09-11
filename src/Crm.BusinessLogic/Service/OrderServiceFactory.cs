namespace Crm.BusinessLogic;
using DataAccess;

public static class OrderServiceFactory
{
    public static IOrderService CreateOrderService()
    {
        IOrderRepository orderRepository = new OrderRepository();
        return new OrderService(orderRepository);
    }


    // public static IOrderService GetPorsgreSQLOderService()
    // {
    //     IOrderRepository orderRepository = new PostgreSQLOrderRepository();
    //     return new OrderServce(orderRepository);
    // }
}