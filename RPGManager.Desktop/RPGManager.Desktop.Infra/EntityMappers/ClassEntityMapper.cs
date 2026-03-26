using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class ClassEntityMapper : EntityBaseEntityMapper<Class>
{
    protected override void Map( EntityTypeBuilder<Class> builder )
    {
        builder.Property( p => p.GameSystemId ).IsRequired();
        builder.Property( p => p.PrimaryAbilityScoreId ).IsRequired();
        builder.Property( p => p.HitDiceTypeId ).IsRequired();
        builder.Property( p => p.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );

        builder.HasOne( e => e.GameSystem ).WithMany( e => e.Classes ).HasForeignKey( e => e.GameSystemId );
        builder.HasOne( e => e.PrimaryAbilityScore ).WithMany( e => e.PrimaryClassAbilityScore ).HasForeignKey( e => e.PrimaryAbilityScoreId );
        builder.HasOne( e => e.HitDiceType ).WithMany().HasForeignKey( e => e.HitDiceTypeId );
    }
}
