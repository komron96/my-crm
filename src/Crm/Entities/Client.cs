namespace Crm.Entities;

public sealed class Client
{
    private string? _firstName;
    private string? _lastName;

    public long Id { get; set; }
    public required string FirstName
    {
        get => _firstName ?? string.Empty;

        set => _firstName = value is {Length: > 0} ? value : throw new ExecutionEngineException(nameof(value));

    }
    public required string LastName 
    { 
        get => _lastName ?? string.Empty;
        set => _lastName = value is {Length: > 0} ? value : throw new ExecutionEngineException(nameof(value));
    }

    public string MiddleName { get; set; }
    public short Age { get; set; }
    public string PassportNumber { get; set; }
    public Gender Gender { get; set; }
}
