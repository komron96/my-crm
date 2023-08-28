namespace Crm.DataAccess;

public sealed class Client
{
    private string? _firstName;
    private string? _lastName;
    private string? _phone;
    private string? _email;
    private string? _password;



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
