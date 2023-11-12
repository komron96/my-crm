using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Crm.DataAccess;

public static class ServiceExtension
{
    private static string DefaultConnectionKeyName => "DefaultConnection";
    public static void ConfigureDataAcces(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DbContext>(
            opt => opt.UseNpgsql(configuration.GetConnectionString(DefaultConnectionKeyName)));

        services.AddScoped<IOrderRepository, PosgresqlOrderRepository>();
    }
}