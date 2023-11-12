namespace Crm.DataAccess;
public readonly record struct ClientInfo(
    long Id,
    string FirstName,
    string LastName,
    string MiddleName,
    string Phone,
    string Email,
    string Password,
    string PassportNumber,
    short Age,
    string Gender);