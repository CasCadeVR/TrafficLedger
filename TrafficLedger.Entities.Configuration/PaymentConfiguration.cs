using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrafficLedger.Entities.ValidationRules;

namespace TrafficLedger.Entities.Configuration;

/// <summary>
/// Описывает конфигурацию для <see cref="Payment"/>
/// </summary>
public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    /// <summary>
    /// Конфигурация для <see cref="Payment"/>
    /// </summary>
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.ToTable("Payment");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Date).IsRequired();
        builder.Property(x => x.Status).IsRequired();
        builder.Property(x => x.EntityId).IsRequired();

        builder.Property(x => x.EntityType)
            .IsRequired()
            .HasMaxLength(MultiTypedDataBaseEntityValidationRules.EntityTypeMaxLength);

        builder.Property(x => x.Commentary)
            .HasMaxLength(RequestedDataBaseEntityValidationRules.CommentaryMaxLength);

        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .IsRequired();

        builder.HasOne(x => x.ProcessedBy)
           .WithMany()
           .HasForeignKey(x => x.ProcessedById)
           .OnDelete(DeleteBehavior.ClientSetNull);
    }
}
