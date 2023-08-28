namespace Crm.BusinessLogic;

public readonly record struct OrderInfo
(
    long Id,
    string Description,
    short Price,
    string Date,
    string Delivery,
    string Address,
    string OrderState
);
