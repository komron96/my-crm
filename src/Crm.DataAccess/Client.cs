namespace Crm.DataAccess;

public sealed class Client
{
    public long Id { get; set;}
    public string FirstName{get; set;} = string.Empty;  //Если не будет уставнолено значение то будет уставновлено по дефолту пустая строка ""
    public string LastName{get; set;} = string.Empty;
    public string? MiddleName { get; set; }
    public string Password{get; set;} = string.Empty;
    public string Phone{get; set;} = string.Empty;
    public string? Email{get; set;}
    public string? PassportNumber { get; set; }
    public short Age { get; set; }
    public Gender Gender { get; set; }
}
