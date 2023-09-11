namespace Crm.BusinessLogic;
using Crm.DataAccess;

public interface IStatisticsService
{
    int ClientCount();
    int OrderCount();
    int OrderStateCount(OrderState orderState);
}
