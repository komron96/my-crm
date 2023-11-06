using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Crm.DataAccess;

[Table("client")]
// [EntityTypeConfiguration(typeof(ClientConfiguration))] //примнение конфигураций из файла
public sealed class Client
{
    [Column("id")]
    [Required]
    public long Id { get; set; }


    [Column("first_name")]
    [Required]
    [DataType("VARCHAR(20)")]
    public string FirstName { get; set; } = string.Empty;

    [Column("last_name")]
    [Required]
    [DataType("VARCHAR(20)")]
    public string LastName { get; set; } = string.Empty;

    [Column("middle_name")]
    [DataType("VARCHAR(20)")]
    public string? MiddleName { get; set; }

    [Column("password")]
    [Required]
    [DataType("VARCHAR(20)")]
    public string Password { get; set; } = string.Empty;

    [Column("phone")]
    [Required]
    public string Phone { get; set; } = string.Empty;

    [Column("email")]
    [DataType("VARCHAR(20)")]
    public string? Email { get; set; }

    [Column("passport_number")]
    [DataType("VARCHAR(20)")]
    public string? PassportNumber { get; set; }

    [Column("age")]
    [Required]
    public short Age { get; set; }

    [Column("gender")]
    [Required]
    public Gender Gender { get; set; }

}
