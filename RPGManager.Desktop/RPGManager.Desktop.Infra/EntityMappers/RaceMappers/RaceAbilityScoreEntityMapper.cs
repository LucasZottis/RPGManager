using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.RaceMappers;

public class RaceAbilityScoreEntityMapper : EntityBaseEntityMapper<RaceAbilityScore>
{
    protected override void Map( EntityTypeBuilder<RaceAbilityScore> builder )
    {
        builder.Property( e => e.RaceId ).IsRequired();
        builder.Property( e => e.AbilityScoreId ).IsRequired();
        builder.Property( e => e.Increase ).IsRequired().HasDefaultValue( 1 );

        builder.HasOne( e => e.Race ).WithMany( e => e.AbilityScores ).HasForeignKey( e => e.RaceId );
        builder.HasOne( e => e.AbilityScore ).WithMany().HasForeignKey( e => e.AbilityScoreId );
    }
}
