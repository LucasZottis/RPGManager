using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.Backgrounds.BackgroundAbilityScores;

namespace RPGManager.Desktop.Infra.EntityMappers.BackgroundMappers;

public class BackgroundAbilityScoreOptionEntityMapper : IEntityTypeConfiguration<BackgroundAbilityScoreOption>
{
    public void Configure( EntityTypeBuilder<BackgroundAbilityScoreOption> builder )
    {
        builder.Property( e => e.BackgroundAbilityScoreChoiceId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.AbilityScoreId ).IsRequired().ValueGeneratedNever();

        builder.HasKey( e => new { e.BackgroundAbilityScoreChoiceId, e.AbilityScoreId } );

        builder.HasOne( e => e.BackgroundAbilityScoreChoice ).WithMany( e => e.Options ).HasForeignKey( e => e.BackgroundAbilityScoreChoiceId );
        builder.HasOne( e => e.AbilityScore ).WithMany().HasForeignKey( e => e.AbilityScoreId );
    }
}
