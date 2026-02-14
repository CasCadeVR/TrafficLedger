using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrafficLedger.Entities.ValidationRules;

namespace TrafficLedger.Entities.Configuration;

/// <summary>
/// Описывает конфигурацию для <see cref="Attachment"/>
/// </summary>
public class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
{
    /// <summary>
    /// Конфигурация для <see cref="Attachment"/>
    /// </summary>
    public void Configure(EntityTypeBuilder<Attachment> builder)
    {
        builder.ToTable("Attachment");

        builder.HasKey(x => x.Id);

        builder.Property(a => a.EntityId).IsRequired();

        builder.Property(a => a.EntityType)
            .IsRequired()
            .HasMaxLength(MultiTypedDataBaseEntityValidationRules.EntityTypeMaxLength);

        builder.Property(a => a.FileName)
            .IsRequired()
            .HasMaxLength(AttachmentValidationRules.FileNameMaxLength);

        builder.Property(a => a.ContentType)
            .IsRequired()
            .HasMaxLength(AttachmentValidationRules.ContentTypeMaxLength);

        builder.Property(a => a.Content).HasColumnType("varbinary(max)");
    }
}
