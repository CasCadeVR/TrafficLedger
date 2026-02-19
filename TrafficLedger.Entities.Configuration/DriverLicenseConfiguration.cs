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

        builder.Property(x => x.Commentary)
            .HasMaxLength(RequestedDataBaseEntityValidationRules.CommentaryMaxLength);

        builder.Property(x => x.DateOfIssue).IsRequired();

        builder.Property(x => x.IssuedBy)
            .IsRequired()
            .HasMaxLength(DriverLicenseValidationRules.IssuedByMaxLength);

        builder.Property(x => x.Residence)
            .IsRequired()
            .HasMaxLength(DriverLicenseValidationRules.ResidenceMaxLength);

        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(x => x.ProcessedBy)
           .WithMany()
           .HasForeignKey(x => x.ProcessedById)
           .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(x => x.Driver)
             .WithMany()
             .HasForeignKey(x => x.DriverId)
             .IsRequired();

        builder.HasOne(x => x.Attachment)
            .WithMany()
            .HasForeignKey(x => x.AttachmentId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasIndex(x => x.LicenseNumber, $"IX_{nameof(DriverLicense)}_{nameof(DriverLicense.LicenseNumber)}")
                .IsUnique()
                .HasFilter($"\"{nameof(DriverLicense.DeletedAt)}\" IS NULL");
    }
}
