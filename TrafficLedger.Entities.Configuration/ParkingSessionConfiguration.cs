using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrafficLedger.Entities.Configuration;

/// <summary>
/// Описывает конфигурацию для <see cref="ParkingSession"/>
/// </summary>
public class ParkingSessionConfiguration : IEntityTypeConfiguration<ParkingSession>
{
    /// <summary>
    /// Конфигурация для <see cref="ParkingSession"/>
    /// </summary>
    public void Configure(EntityTypeBuilder<ParkingSession> builder)
    {
        builder.ToTable("ParkingSession");

        builder.HasKey(x => x.Id);

        builder.Property(a => a.StartTime).IsRequired();
        builder.Property(a => a.Status).IsRequired();

        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .IsRequired();

        builder.HasOne(x => x.Transport)
           .WithMany()
           .HasForeignKey(x => x.TransportId)
           .IsRequired();

        builder.HasOne(x => x.ParkingZone)
           .WithMany()
           .HasForeignKey(x => x.ParkingZoneId)
           .IsRequired();
    }
}
