namespace Crm.DataAccess;

public readonly struct OrderInfo
{
    public readonly string OrderID { get; init; }
    public readonly string Description { get; init; }
    public readonly string Price { get; init; }
    public readonly short Date { get; init; }
    public readonly string Delivery { get; init; }
    public readonly string Adress { get; init; }
    public readonly string OrderState {get;init;}
}