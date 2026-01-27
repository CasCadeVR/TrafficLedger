using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrafficLedger.Entities.ValidationRules;

namespace TrafficLedger.Entities.Configuration;

/// <summary>
/// Описывает конфигурацию для <see cref="Fine"/>
/// </summary>
public class FineConfiguration : IEntityTypeConfiguration<Fine>
{
    /// <summary>
    /// Конфигурация для <see cref="Fine"/>
    /// </summary>
    public void Configure(EntityTypeBuilder<Fine> builder)
    {
        builder.ToTable("Fine");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Date).IsRequired();
        builder.Property(x => x.Status).IsRequired();

        builder.Property(x => x.Address)
            .IsRequired()
            .HasMaxLength(FineValidationRules.AddressMaxLength);

        builder.HasOne(x => x.Violation)
             .WithMany()
             .HasForeignKey(x => x.ViolationId)
             .IsRequired();

        builder.HasOne(x => x.Transport)
             .WithMany(x => x.Fines)
             .HasForeignKey(x => x.TransportId)
             .IsRequired();
    }
}
