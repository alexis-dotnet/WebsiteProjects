using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pagos.Auto.Entities;

namespace Pagos.Auto.Mapping
{
    public class CarPaymentMap : IEntityTypeConfiguration<CarPayment>
    {
        public void Configure(EntityTypeBuilder<CarPayment> builder)
        {
            builder.ToTable("CarPayments", "dbo");
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Id);
            builder.Property(t => t.PaymentDate);
            builder.Property(t => t.Amount);
            builder.Property(t => t.FileName);
            builder.Property(t => t.Comment);
        }
    }
}
