using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class AbilityScoreEntityMapper : GameSystemVersionBaseEntityMapper<AbilityScore>
{
    private readonly DnD521Seed _dnD521Seed;
    public AbilityScoreEntityMapper(DnD521Seed dnD521Seed)
    {
        _dnD521Seed = dnD521Seed;
    }
    protected override void Map( EntityTypeBuilder<AbilityScore> builder )
    {
        builder.Property( e => e.GameSystemVersionId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Abbreviation ).HasMaxLength( 3 );
        builder.Property( e => e.Description );

        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.AbilityScores ).HasForeignKey( e => e.GameSystemVersionId );

        builder.HasData( _dnD521Seed.GetAbilityScore() );
    }
}