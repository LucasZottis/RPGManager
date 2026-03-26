using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.RaceMappers;

public class RaceLanguageEntityMapper : EntityBaseEntityMapper<RaceLanguage>
{
    protected override void Map( EntityTypeBuilder<RaceLanguage> builder )
    {
        builder.Property( e => e.RaceId ).IsRequired();
        builder.Property( e => e.LanguageId );
        builder.Property( e => e.IsChoice ).IsRequired();

        builder.HasOne( e => e.Race ).WithMany().HasForeignKey( e => e.RaceId );
        builder.HasOne( e => e.Language ).WithMany().HasForeignKey( e => e.LanguageId );
    }
}
