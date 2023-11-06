
using System.Data;
using Npgsql;

namespace Crm.DataAccess;

public sealed class PosgresqlOrderRepository : IOrderRepository
{
    private readonly NpgsqlConnection _npgsqlConnection;
    PosgresqlOrderRepository(NpgsqlConnection npgsqlConnection)
    {
        _npgsqlConnection = npgsqlConnection;
    }
    PosgresqlOrderRepository()
    {
        _npgsqlConnection = new(SqlHelper.connectionString);
    }

    public async Task<bool> CreateOrderAsync(Order order, CancellationToken cancellationToken)
    {
        string connectionString = "данные подключения";
        try
        {
            using NpgsqlConnection con = new(connectionString);
            await con.OpenAsync(cancellationToken);

            string insertQuery = "INSERT INTO Order (Description, Price, Date, Delivery, Address, OrderState) " +
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

    bool IOrderRepository.DeleteOrder(long orderId)
    {
        throw new NotImplementedException();
    }

    bool IOrderRepository.GetOrder(long OrderId)
    {
        throw new NotImplementedException();
    }

    int IOrderRepository.OrderCount()
    {
        throw new NotImplementedException();
    }

    int IOrderRepository.OrderStateCount(OrderState orderState)
    {
        throw new NotImplementedException();
    }

    bool IOrderRepository.UpdateOrderState(long orderId, OrderState orderstate)
    {
        throw new NotImplementedException();
    }
}