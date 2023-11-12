using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crm.DataAccess;

public sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> modelBuilder)
    {
        modelBuilder.HasKey(p => p.Id);
        modelBuilder.Property(p => p.Id).HasColumnType("SERIAL").HasColumnName("id").IsRequired();
        modelBuilder.Property(p => p.Price).HasColumnType("smallint").HasColumnName("price").IsRequired();
        modelBuilder.Property(p => p.OrderState).HasColumnType("smallint").HasColumnName("order_state").IsRequired();
        modelBuilder.Property(p => p.Description).HasColumnType("VARCHAR(20)").HasColumnName("description");
        modelBuilder.Property(p => p.Date).HasColumnType("VARCHAR(20)").HasColumnName("created_at");
        modelBuilder.Property(p => p.Delivery).HasColumnType("VARCHAR(20)").HasColumnName("delivery");
        modelBuilder.Property(p => p.Address).HasColumnType("VARCHAR(20)").HasColumnName("address").IsRequired();
    }
}
