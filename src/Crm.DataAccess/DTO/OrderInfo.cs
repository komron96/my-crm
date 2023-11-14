namespace Crm.DataAccess;
public readonly record struct OrderInfo(
    long Id,
    short Price,
    string OrderState,
    string Description,
    string Date,
    string Address,
    long DeliveryId
    );
