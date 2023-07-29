namespace Crm.Entities;

public sealed class Order
{
    private readonly string? _price;
    private readonly string? _id;
    public string ID
    {
      
    get => _id ?? string.Empty;
    init => _id = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    
    }
    public string Description { get; set; }
    public required string Price 
    {   
    get => _price ?? string.Empty;
    init => _price = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public short Date { get; set; }
    public string Delivery { get; set; }
    public string Adress { get; set; }
}
