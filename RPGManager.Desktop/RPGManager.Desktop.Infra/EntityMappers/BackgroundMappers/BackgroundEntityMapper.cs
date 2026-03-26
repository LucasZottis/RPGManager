using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Entities.Backgrounds.BackgroundAbilityScores;
using RPGManager.Desktop.Domain.Entities.Backgrounds.ToolProficiencies;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.BackgroundMappers;

public class BackgroundEntityMapper : GameSystemVersionBaseEntityMapper<Background>
{
    protected override void Map( EntityTypeBuilder<Background> builder )
    {
        builder.Property( p => p.GameSystemVersionId );
        builder.Property( p => p.Name ).HasMaxLength( MaxLength.ShortName );
        builder.Property( p => p.Description ).IsRequired( false );

        builder.HasOne( b => b.AbilityScoreChoice )
            .WithOne( a => a.Background )
            .HasForeignKey<BackgroundAbilityScoreChoice>( a => a.BackgroundId );

        builder.HasOne( b => b.ToolProficiency )
            .WithOne( a => a.Background )
            .HasForeignKey<BackgroundToolProficiency>( a => a.BackgroundId )
            .IsRequired(false);

        builder.HasOne( b => b.ToolProficiencyChoice )
            .WithOne( a => a.Background )
            .HasForeignKey<BackgroundToolProficiencyChoice>( a => a.BackgroundId )
            .IsRequired( false );
    }
}