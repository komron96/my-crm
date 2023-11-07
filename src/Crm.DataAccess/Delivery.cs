namespace Crm.DataAccess;

public sealed class Delivery
{
    public long Id { get; set; }
    public DeliveryType DeliveryType { get; set; }
    public string Address { get; set; } = string.Empty;
    public string CourierName { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public DateTime DeliveryDate { get; set; }
    public long OrderId { get; set; }
    public Order Order { get; set; }
}
