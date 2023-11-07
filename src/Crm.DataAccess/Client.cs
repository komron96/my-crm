using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Crm.DataAccess;

[Table("client")]
// [EntityTypeConfiguration(typeof(ClientConfiguration))] //примнение конфигураций из файла
public sealed class Client
{
    public long Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? MiddleName { get; set; }
    public string Password { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string? Email { get; set;}
    public string? PassportNumber { get; set; }
    public short Age { get; set; }
    public Gender Gender { get; set; }
    public ICollection<Order> Orders {get;set;}
}
