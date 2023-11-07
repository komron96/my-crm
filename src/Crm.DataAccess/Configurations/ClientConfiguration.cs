using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crm.DataAccess;

public sealed class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> modelBuilder)
    {
        modelBuilder.HasKey(p => p.Id);
        modelBuilder.Property(p => p.Id).HasColumnType("SERIAL").HasColumnName("id").IsRequired();
        modelBuilder.Property(p => p.FirstName).HasColumnType("VARCHAR(20)").HasColumnName("first_name").IsRequired();
        modelBuilder.Property(p => p.LastName).HasColumnType("VARCHAR(20)").HasColumnName("last_name").IsRequired();
        modelBuilder.Property(p => p.MiddleName).HasColumnType("VARCHAR(20)").HasColumnName("middle_name");
        modelBuilder.Property(p => p.Password).HasColumnType("VARCHAR(20)").HasColumnName("password").IsRequired();
        modelBuilder.Property(p => p.Phone).HasColumnType("VARCHAR(20)").HasColumnName("phone").IsRequired();
        modelBuilder.Property(p => p.Email).HasColumnType("VARCHAR(20)").HasColumnName("email");
        modelBuilder.Property(p => p.PassportNumber).HasColumnType("VARCHAR(20)").HasColumnName("passport_number");
        modelBuilder.Property(p => p.Age).HasColumnType("smallint").HasColumnName("age").IsRequired();
        modelBuilder.Property(p => p.Gender).HasColumnType("smallint").HasColumnName("gender").IsRequired();
        modelBuilder.HasMany(o => o.Orders).WithOne(o => o.Client);
    }
}
