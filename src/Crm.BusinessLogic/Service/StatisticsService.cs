using Crm.DataAccess;

namespace Crm.BusinessLogic;

public sealed class StatisticsService : IStatisticsService
{
    public readonly IOrderRepository _orderRepository;
    public readonly IClientRepository _clientRepository;
    public StatisticsService(IOrderRepository orderRepository, IClientRepository clientRepository)
    {
        _orderRepository = orderRepository;
        _clientRepository = clientRepository;
    }

    public int ClientCount() => _clientRepository.ClientCount();
    public int OrderCount() => _orderRepository.OrderCount();
    public int OrderStateCount(OrderState orderState) => _orderRepository.OrderStateCount(orderState);
} 