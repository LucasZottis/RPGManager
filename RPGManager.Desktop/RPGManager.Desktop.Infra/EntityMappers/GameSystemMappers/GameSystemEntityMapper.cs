using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.GameSystems;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.GameSystemMappers;

public class GameSystemEntityMapper : EntityBaseEntityMapper<GameSystem>
{
    private readonly DnD521Seed _seed;
    public GameSystemEntityMapper( DnD521Seed seed )
    {
        _seed = seed;
    }

    protected override void Map( EntityTypeBuilder<GameSystem> builder )
    {
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );

        builder.HasData( _seed.GetGameSystems() );
    }
}