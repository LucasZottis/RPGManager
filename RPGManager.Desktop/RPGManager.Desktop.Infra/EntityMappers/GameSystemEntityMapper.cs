using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class GameSystemEntityMapper : EntityBaseEntityMapper<GameSystem>
{
    protected override void Map( EntityTypeBuilder<GameSystem> builder )
    {
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
    }
}