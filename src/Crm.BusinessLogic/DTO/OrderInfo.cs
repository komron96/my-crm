namespace Crm.BusinessLogic;
public readonly record struct OrderInfo(
    long Id,
    string OrderState,
    short Price,
    string Description,
    string Date,
    string Delivery,
    string Address);
