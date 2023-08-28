namespace Crm.DataAccess;

public sealed class Order
{
    public long Id {get;set;}
    public short Price {get;set;}
    public OrderState OrderState {get; set;}
    public string Description { get; set; }
    public string Date { get; set; }
    public string Delivery { get; set; }
    public string Address { get; set; }

}
