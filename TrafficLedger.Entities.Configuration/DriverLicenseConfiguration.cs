using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrafficLedger.Entities.ValidationRules;

namespace TrafficLedger.Entities.Configuration;

/// <summary>
/// Описывает конфигурацию для <see cref="DriverLicense"/>
/// </summary>
public class DriverLicenseConfiguration : IEntityTypeConfiguration<DriverLicense>
{
    /// <summary>
    /// Конфигурация для <see cref="DriverLicense"/>
    /// </summary>
    public void Configure(EntityTypeBuilder<DriverLicense> builder)
    {
        builder.ToTable("DriverLicense");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.LicenseNumber)
            .IsRequired()
            .HasMaxLength(DriverLicenseValidationRules.LicenseNumberLength);

        builder.Property(x => x.DateOfIssue).IsRequired();

        builder.Property(x => x.IssuedBy)
            .IsRequired()
            .HasMaxLength(DriverLicenseValidationRules.IssuedByMaxLength);

        builder.Property(x => x.Residence)
            .IsRequired()
            .HasMaxLength(DriverLicenseValidationRules.ResidenceMaxLength);

        builder.HasOne(x => x.Driver)
             .WithMany()
             .HasForeignKey(x => x.DriverId)
             .IsRequired();

        builder.HasIndex(x => x.LicenseNumber, $"IX_{nameof(DriverLicense)}_{nameof(DriverLicense.LicenseNumber)}")
                .IsUnique()
                .HasFilter($"\"{nameof(DriverLicense.DeletedAt)}\" IS NULL");
    }
}
