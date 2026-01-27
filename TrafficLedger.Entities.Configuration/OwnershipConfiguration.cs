using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrafficLedger.Entities.Configuration;

/// <summary>
/// Описывает конфигурацию для <see cref="Ownership"/>
/// </summary>
public class OwnershipConfiguration : IEntityTypeConfiguration<Ownership>
{
    /// <summary>
    /// Конфигурация для <see cref="Ownership"/>
    /// </summary>
    public void Configure(EntityTypeBuilder<Ownership> builder)
    {
        builder.ToTable("Ownership");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Date).IsRequired();

        builder.HasOne(x => x.Transport)
             .WithMany(x => x.Ownerships)
             .HasForeignKey(x => x.TransportId)
             .IsRequired();

        builder.HasOne(x => x.Driver)
             .WithMany(x => x.Ownerships)
             .HasForeignKey(x => x.DriverId)
             .IsRequired();
    }
}
