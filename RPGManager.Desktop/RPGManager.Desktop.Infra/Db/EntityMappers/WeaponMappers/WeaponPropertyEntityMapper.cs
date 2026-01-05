using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Infra.Db.EntityMappers.WeaponMappers;

public class WeaponPropertyEntityMapper : EntityBaseEntityMapper<WeaponProperty>
{
    protected override void Map( EntityTypeBuilder<WeaponProperty> builder )
    {
        builder.Property( e => e.GameSystemId ).IsRequired();
        builder.Property( e => e.AlternativeAbilityScoreId );
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Description );
        builder.Property( e => e.HasAlternativeDiceTypeDamage ).IsRequired().HasDefaultValue( false );

        builder.HasOne( e => e.GameSystem ).WithMany( e => e.WeaponProperties ).HasForeignKey( e => e.GameSystemId );
        builder.HasOne( e => e.AlternativeAbilityScore ).WithMany( e => e.AlternativeAbilityScoreForWeaponProperties ).HasForeignKey( e => e.AlternativeAbilityScoreId );
    }
}