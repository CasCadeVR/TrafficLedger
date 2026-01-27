using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrafficLedger.Entities.ValidationRules;

namespace TrafficLedger.Entities.Configuration;

/// <summary>
/// Описывает конфигурацию для <see cref="Transport"/>
/// </summary>
public class TransportConfiguration : IEntityTypeConfiguration<Transport>
{
    /// <summary>
    /// Конфигурация для <see cref="Transport"/>
    /// </summary>
    public void Configure(EntityTypeBuilder<Transport> builder)
    {
        builder.ToTable("Transport");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.TransportCode)
            .IsRequired()
            .HasMaxLength(TransportValidationRules.TransportCodeLength);

        builder.Property(x => x.Region)
            .HasMaxLength(TransportValidationRules.RegionMaxLength);

        builder.Property(x => x.Brand)
            .IsRequired()
            .HasMaxLength(TransportValidationRules.BrandMaxLength);

        builder.Property(x => x.Year)
            .IsRequired()
            .HasMaxLength(TransportValidationRules.YearLength);

        builder.Property(x => x.Model)
            .IsRequired()
            .HasMaxLength(TransportValidationRules.ModelMaxLength);

        builder.Property(x => x.MileAge).IsRequired();

        builder.HasOne(x => x.TransportCategory)
             .WithMany()
             .HasForeignKey(x => x.TransportCategoryId)
             .IsRequired();

        builder.HasIndex(x => x.TransportCode, $"IX_{nameof(Transport)}_{nameof(Transport.TransportCode)}")
                .IsUnique()
                .HasFilter($"\"{nameof(Transport.DeletedAt)}\" IS NULL");
    }
}
