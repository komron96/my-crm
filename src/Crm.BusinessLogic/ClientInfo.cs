using Crm.DataAccess;
namespace Crm.BusinessLogic;


public readonly struct ClientInfo
{
    public readonly long ClientID {get; init;}
    public readonly string FirstName {get;init;}
    public readonly string LastName{get; init;}
    public readonly string MiddleName{get; init;}
    public readonly string Phone{get; init;}
    public readonly string Email{get; init;}
    public readonly string Password{get; init;}
    public readonly short Age{get; init;}
    public readonly string PassportNumber{get; init;}
    public readonly Gender Gender{get; init;}
}

