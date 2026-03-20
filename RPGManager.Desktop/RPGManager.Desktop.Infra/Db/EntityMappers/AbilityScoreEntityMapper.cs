using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RPGManager.Desktop.Infra.Db.EntityMappers;

public class AbilityScoreEntityMapper : EntityBaseEntityMapper<AbilityScore>
{
    protected override void Map( EntityTypeBuilder<Background> builder )
    {
        builder.Property( e => e.GameSystemId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Abbreviation ).HasMaxLength( 3 );
        builder.Property( e => e.Description );

        builder.HasOne( e => e.GameSystem )
            .WithMany( e => e.AbilityScores )
            .HasForeignKey( e => e.GameSystemId );
    }
}