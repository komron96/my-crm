namespace Crm.DataAccess;

public sealed class Order
{
    private readonly string? _price;
    private readonly string? _id;
    public string Id    
    {
    get => _id ?? string.Empty;
    init => _id = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }


    public required string Price 
    {   
    get => _price ?? string.Empty;
    init => _price = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public OrderState OrderState {get; set;}

    public string Description { get; set; }
    public short Date { get; set; }
    public string Delivery { get; set; }
    public string Address { get; set; }
}
