using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrafficLedger.Entities.ValidationRules;

namespace TrafficLedger.Entities.Configuration;

/// <summary>
/// Описывает конфигурацию для <see cref="TransportCategory"/>
/// </summary>
public class TransportCategoryConfiguration : IEntityTypeConfiguration<TransportCategory>
{
    /// <summary>
    /// Конфигурация для <see cref="TransportCategory"/>
    /// </summary>
    public void Configure(EntityTypeBuilder<TransportCategory> builder)
    {
        builder.ToTable("TransportCategory");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.CategoryName)
            .IsRequired()
            .HasMaxLength(TransportCategoryValidationRules.NameMaxLength);

        builder.Property(x => x.Description)
            .HasMaxLength(TransportCategoryValidationRules.DescriptionMaxLength);

        builder.HasIndex(x => x.CategoryName, $"IX_{nameof(TransportCategory)}_{nameof(TransportCategory.CategoryName)}")
                .IsUnique()
                .HasFilter($"\"{nameof(TransportCategory.DeletedAt)}\" IS NULL");
    }
}
