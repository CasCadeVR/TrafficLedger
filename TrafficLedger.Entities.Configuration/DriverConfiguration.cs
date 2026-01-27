using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrafficLedger.Entities.ValidationRules;

namespace TrafficLedger.Entities.Configuration;

/// <summary>
/// Описывает конфигурацию для <see cref="Driver"/>
/// </summary>
public class DriverConfiguration : IEntityTypeConfiguration<Driver>
{
    /// <summary>
    /// Конфигурация для <see cref="Driver"/>
    /// </summary>
    public void Configure(EntityTypeBuilder<Driver> builder)
    {
        builder.ToTable("Driver");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.UniqueId).ValueGeneratedOnAdd();
        builder.Property(x => x.FullName).IsRequired().HasMaxLength(DriverValidationRules.FullNameMaxLength);
        builder.Property(x => x.BirthDate).IsRequired();
        builder.Property(x => x.BirthPlace).IsRequired().HasMaxLength(DriverValidationRules.BirthPlaceMaxLength);

        builder.HasOne(x => x.User)
             .WithMany()
             .HasForeignKey(x => x.UserId)
             .IsRequired();
    }
}