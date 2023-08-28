using Crm.DataAccess;
namespace Crm.BusinessLogic;

public static class GenderExtenstion
{
    public static Gender TogenderEnum(this string genderStr)
        => Enum.Parse<Gender>(genderStr);
}
