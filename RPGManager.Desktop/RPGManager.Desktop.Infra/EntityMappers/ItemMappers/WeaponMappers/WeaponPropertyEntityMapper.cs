using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.WeaponMappers;

public class WeaponPropertyEntityMapper : GameSystemVersionBaseEntityMapper<WeaponProperty>
{
    protected override void Map( EntityTypeBuilder<WeaponProperty> builder )
    {
        builder.Property( e => e.AlternativeAbilityScoreId );
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Description );
        builder.Property( e => e.HasAlternativeDiceTypeDamage ).IsRequired().HasDefaultValue( false );

        builder.HasOne( e => e.AlternativeAbilityScore ).WithMany( e => e.AlternativeAbilityScoreForWeaponProperties ).HasForeignKey( e => e.AlternativeAbilityScoreId );
    }
}