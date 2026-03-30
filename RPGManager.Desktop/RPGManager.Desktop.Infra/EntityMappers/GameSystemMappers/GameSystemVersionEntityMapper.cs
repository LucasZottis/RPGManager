using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.GameSystems;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.GameSystemMappers;

public class GameSystemVersionEntityMapper : EntityBaseEntityMapper<GameSystemVersion>
{
    protected override void Map( EntityTypeBuilder<GameSystemVersion> builder )
    {
        builder.Property( e => e.GameSystemId ).IsRequired();
        builder.Property( e => e.Version ).HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.LegalInformation ).IsRequired( false );

        builder.HasOne( e => e.GameSystem ).WithMany( e => e.Versions ).HasForeignKey( e => e.GameSystemId );
    }
}