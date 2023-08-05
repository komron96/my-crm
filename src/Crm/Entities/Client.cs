namespace Crm.Entities;

public sealed class Client
{
    private string? _firstName;
    private string? _lastName;
    private string? _phone;
    private string? _email;
    private string? _password;



    public long Id { get; set; }
    
    public required string FirstName
    {
        get => _firstName ?? string.Empty;

        set => _firstName = value is {Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));

    }
    public required string LastName 
    { 
        get => _lastName ?? string.Empty;
        set => _lastName = value is {Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
      public required string Phone 
    { 
        get => _phone ?? string.Empty;
        set => _phone = value is {Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
      public required string Email 
    { 
        get => _email ?? string.Empty;
        set => _email = value is {Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
      public required string Password
    { 
        get => _password ?? string.Empty;
        set => _password = value is {Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public string MiddleName { get; set; }
    public short Age { get; set; }
    public string PassportNumber { get; set; }
    public Gender Gender { get; set; }
}
