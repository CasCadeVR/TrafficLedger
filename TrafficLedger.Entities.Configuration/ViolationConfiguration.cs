using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrafficLedger.Entities.ValidationRules;

namespace TrafficLedger.Entities.Configuration;

/// <summary>
/// Описывает конфигурацию для <see cref="Violation"/>
/// </summary>
public class ViolationConfiguration : IEntityTypeConfiguration<Violation>
{
    /// <summary>
    /// Конфигурация для <see cref="Violation"/>
    /// </summary>
    public void Configure(EntityTypeBuilder<Violation> builder)
    {
        builder.ToTable("Violation");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.ViolationCode)
            .IsRequired()
            .HasMaxLength(ViolationValidationRules.CodeMaxLength);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(ViolationValidationRules.NameMaxLength);

        builder.Property(x => x.MinFinePrice).IsRequired();
        builder.Property(x => x.Description);

        builder.HasIndex(x => x.ViolationCode, $"IX_{nameof(Violation)}_{nameof(Violation.ViolationCode)}")
                .IsUnique()
                .HasFilter($"\"{nameof(Violation.DeletedAt)}\" IS NULL");
    }
}
