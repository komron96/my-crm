namespace Crm.DataAccess;

public static class IntegerExtensions
{
    public static bool TryParseGender(this int genderIndex, out Gender gender)
    {
        switch(genderIndex)
        {
            case 0:
                gender = Gender.Male;
                return true;
            case 1:
                gender = Gender.Female;
                return true;
            default:
                gender = default;
                return false;
        }
    }
        public static bool TryParseorderState(this int stateIndex, out OrderState orderState)
    {
        switch(stateIndex)
        {
            case 0:
                orderState = OrderState.Pending;
                return true;
            case 1:
                orderState = OrderState.Approved;
                return true;
            case 3:
                orderState = OrderState.Canceled;
                return true;
            default:
                orderState = default;
                return false;
        }
    }
}