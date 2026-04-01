using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.GameSystems;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.GameSystemMappers;

public class GameSystemVersionEntityMapper : EntityBaseEntityMapper<GameSystemVersion>
{
    private readonly DnD521Seed _seed;
    
    public GameSystemVersionEntityMapper( DnD521Seed seed )
    {
        _seed = seed;
    }

    protected override void Map( EntityTypeBuilder<GameSystemVersion> builder )
    {
        builder.Property( e => e.GameSystemId ).IsRequired();
        builder.Property( e => e.Version ).HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.LegalInformation ).IsRequired( false );

        builder.HasOne( e => e.GameSystem ).WithMany( e => e.Versions ).HasForeignKey( e => e.GameSystemId );

        builder.HasData( _seed.GetGameSystemVersions() );
    }
}