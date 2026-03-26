using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.WeaponMappers;

public class WeaponEntityMapper : EntityBaseEntityMapper<Weapon>
{
    protected override void Map( EntityTypeBuilder<Weapon> builder )
    {
        builder.Property( e => e.ItemId ).IsRequired();
        builder.Property( e => e.WeaponCategoryId ).IsRequired();
        builder.Property( e => e.WeaponTypeId ).IsRequired();
        builder.Property( e => e.WeaponMasteryPropertyId ).IsRequired();
        builder.Property( e => e.BaseAbilityScoreId ).IsRequired();

        builder.HasOne( e => e.Item ).WithOne( e => e.Weapon ).HasForeignKey<Weapon>( e => e.ItemId );
        builder.HasOne( e => e.WeaponCategory ).WithMany( e => e.Weapons ).HasForeignKey( e => e.WeaponCategoryId );
        builder.HasOne( e => e.WeaponType ).WithMany( e => e.Weapons ).HasForeignKey( e => e.WeaponTypeId );
        builder.HasOne( e => e.WeaponMasteryProperty ).WithMany().HasForeignKey( e => e.WeaponMasteryPropertyId );
        builder.HasOne( e => e.BaseAbilityScore ).WithMany( e => e.Weapons ).HasForeignKey( e => e.BaseAbilityScoreId );
    }
}
