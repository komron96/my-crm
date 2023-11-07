using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crm.DataAccess;

public sealed class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>
{
    public void Configure(EntityTypeBuilder<Delivery> modelBuilder)
    {
        modelBuilder.HasOne(d => d.Order).WithOne(d => d.Delivery).HasForeignKey<Order>(d=> d.DeliveryId);
    }
}
