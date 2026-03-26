using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class ClassEntityMapper : EntityBaseEntityMapper<Class>
{
    protected override void Map( EntityTypeBuilder<Class> builder )
    {
        builder.Property( p => p.GameSystemVersionId ).IsRequired();
        builder.Property( p => p.PrimaryAbilityScoreId ).IsRequired();
        builder.Property( p => p.HitDiceTypeId ).IsRequired();
        builder.Property( p => p.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );

        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.Classes ).HasForeignKey( e => e.GameSystemVersionId );
        builder.HasOne( e => e.PrimaryAbilityScore ).WithMany( e => e.PrimaryClassAbilityScore ).HasForeignKey( e => e.PrimaryAbilityScoreId );
        builder.HasOne( e => e.HitDiceType ).WithMany( e => e.HitDiceClasses ).HasForeignKey( e => e.HitDiceTypeId );
    }
}
