using System.Net.Security;
using Microsoft.EntityFrameworkCore;

namespace Crm.DataAccess;

public sealed class CrmDbContex : DbContext
{
    public DbSet<Order> Orders { get; set; }  //Указываем какие таблицы у нас должны быть
    public DbSet<Client> Clients { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)   //если сервер уже настроен то просто ретёрним.
            return;

        optionsBuilder.UseNpgsql(DataBaseHelper.connectionString);
        //соединяемся с БД, EF CORE сам поймёт что БД должен быть под Posgres, так как используется UserNpg
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClientConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new DeliveryConfiguration());
    }
}
