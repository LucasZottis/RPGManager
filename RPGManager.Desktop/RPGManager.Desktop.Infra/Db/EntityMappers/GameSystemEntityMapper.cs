using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RPGManager.Desktop.Infra.Db.EntityMappers;

public class GameSystemEntityMapper : EntityBaseEntityMapper<GameSystem>
{
    protected override void Map( EntityTypeBuilder<GameSystem> builder )
    {
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
    }
}