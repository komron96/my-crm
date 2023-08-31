namespace Crm.BusinessLogic;


public interface IStatisticsService
{
    public int GetClientCount();
    public int GetOrderCount();
    public int GetOrderStateCount();
}

public sealed class StatisticsService : IStatisticsService
{

}