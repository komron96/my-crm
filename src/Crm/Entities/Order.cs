namespace Crm.Entities;

public sealed class Order
{
    public string orderID { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public short Date { get; set; }
    public string Delivery { get; set; }
    public string Adress { get; set; }
}
