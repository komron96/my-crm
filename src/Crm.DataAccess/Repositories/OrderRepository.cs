using System.Data;
using Npgsql;

namespace Crm.DataAccess;

public sealed class OrderRepository : IOrderRepository
{
    private readonly List<Order> _orders;
    private long _id = 0;

    public OrderRepository()
    {
        _orders = new List<Order>();
    }


public async Task<bool> CreateAsync(Order order, CancellationToken cancellationToken)
{
    string connectionString = "данные подключения";
    try
    {
        using NpgsqlConnection con = new(connectionString);
        await con.OpenAsync(cancellationToken);

        string insertQuery = "INSERT INTO Orders (Description, Price, Date, Delivery, Address, OrderState) " +
                             "VALUES (@Description, @Price, @Date, @Delivery, @Address, @OrderState) ";

        using NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, con);
        cmd.Parameters.AddWithValue("@Description", order.Description);
        cmd.Parameters.AddWithValue("@Price", order.Price);
        cmd.Parameters.AddWithValue("@Date", order.Date);
        cmd.Parameters.AddWithValue("@Delivery", order.Delivery);
        cmd.Parameters.AddWithValue("@Address", order.Address);
        cmd.Parameters.AddWithValue("@OrderState", order.OrderState);
        long newOrderId = (long)await cmd.ExecuteScalarAsync(cancellationToken);
        return newOrderId > 0;
    }
    
    catch (OperationCanceledException)
    {
        Console.WriteLine("Создание ордера отменён пользователем");
        return false;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Создание ордера зафейлилась, проверьте код {ex}");
        return false;
    }
}



    public bool GetOrder(long orderId)
    {
        Order order = _orders.Find(item => item.Id == orderId);
        return true;
    }

    public bool DeleteOrder(long orderId)
    {
        int clientIndex = _orders.FindIndex(item => item.Id == orderId);
        if (clientIndex < 0)
            return false;
        _orders.RemoveAt(clientIndex);
        return true;
    }

    public bool UpdateOrderState(long orderId, OrderState newOrderState)
    {
        Order? order = _orders.Find(item => item.Id == orderId);
        if (order is null) return false;
        order.OrderState = newOrderState;
        return true;
    }


    //Counts
    public int OrderCount() => _orders.Count;

    public int OrderStateCount(OrderState orderState) => _orders.Count(item => item.OrderState == orderState);
}
