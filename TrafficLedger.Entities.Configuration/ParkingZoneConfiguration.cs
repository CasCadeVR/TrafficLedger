using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrafficLedger.Entities.ValidationRules;

namespace TrafficLedger.Entities.Configuration;

/// <summary>
/// Описывает конфигурацию для <see cref="ParkingZone"/>
/// </summary>
public class ParkingZoneConfiguration : IEntityTypeConfiguration<ParkingZone>
{
    /// <summary>
    /// Конфигурация для <see cref="ParkingZone"/>
    /// </summary>
    public void Configure(EntityTypeBuilder<ParkingZone> builder)
    {
        builder.ToTable("ParkingZone");

        builder.HasKey(x => x.Id);

        builder.Property(a => a.Address)
            .HasMaxLength(ParkingZoneValidationRules.AddressMaxLength);

        builder.Property(a => a.HourlyRate).IsRequired();

        builder.HasIndex(x => x.Address, $"IX_{nameof(ParkingZone)}_{nameof(ParkingZone.Address)}")
                .IsUnique()
                .HasFilter($"\"{nameof(ParkingZone.DeletedAt)}\" IS NULL");
    }
}
