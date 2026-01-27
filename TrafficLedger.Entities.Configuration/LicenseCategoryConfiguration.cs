using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrafficLedger.Entities.Configuration;

/// <summary>
/// Описывает конфигурацию для <see cref="LicenseCategory"/>
/// </summary>
public class LicenseCategoryConfiguration : IEntityTypeConfiguration<LicenseCategory>
{
    /// <summary>
    /// Конфигурация для <see cref="LicenseCategory"/>
    /// </summary>
    public void Configure(EntityTypeBuilder<LicenseCategory> builder)
    {
        builder.ToTable("LicenseCategory");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Date).IsRequired();

        builder.HasOne(x => x.DriverLicense)
             .WithMany(x => x.LicenseCategories)
             .HasForeignKey(x => x.DriverLicenseId)
             .IsRequired();

        builder.HasOne(x => x.TransportCategory)
             .WithMany()
             .HasForeignKey(x => x.TransportCategoryId)
             .IsRequired();
    }
}
