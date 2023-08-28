using Crm.DataAccess;
namespace Crm.BusinessLogic;

public static class StateExtestion
{
    public static OrderState ToOrderStateEnum(this string orderstateStr)
        => Enum.Parse<OrderState>(orderstateStr);
}
