using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Orders;

namespace Nop.Data.Mapping.Customers
{
    /// <summary>
    /// Mapping class
    /// </summary>
    public partial class RewardPointsHistoryMap : NopEntityTypeConfiguration<RewardPointsHistory>
    {
        public override void Configure(EntityTypeBuilder<RewardPointsHistory> builder)
        {
            base.Configure(builder);
            builder.ToTable("RewardPointsHistory");
            builder.HasKey(rph => rph.Id);

            builder.Property(rph => rph.UsedAmount);

            builder.HasOne(rph => rph.Customer)
                .WithMany()
                .HasForeignKey(rph => rph.CustomerId)
                .IsRequired(true);

            builder.HasOne(rph => rph.UsedWithOrder)
                .WithOne(o => o.RedeemedRewardPointsEntry)
                .HasForeignKey<Order>(o => o.Id)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}