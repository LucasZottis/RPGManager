using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Infra.Db.EntityMappers.WeaponMappers;

public class WeaponEntityMapper : EntityBaseEntityMapper<Weapon>
{
    protected override void Map( EntityTypeBuilder<Weapon> builder )
    {
        builder.Property( e => e.GameSystemId ).IsRequired();
        builder.Property( e => e.WeaponCategoryId ).IsRequired();
        builder.Property( e => e.WeaponTypeId ).IsRequired();
        builder.Property( e => e.BaseAbilityScoreId ).IsRequired();
        //builder.Property( e => e.AlternativeAbilityScoreId );
        builder.Property( e => e.CurrencyTypeId );
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.MediumName );
        builder.Property( e => e.Description );
        builder.Property( e => e.Price ).IsRequired();
        builder.Property( e => e.Weight ).IsRequired();
        builder.Property( e => e.NormalRange );
        builder.Property( e => e.LongRange );

        builder.HasOne( e => e.GameSystem ).WithMany( e => e.Weapons ).HasForeignKey( e => e.GameSystemId );
        builder.HasOne( e => e.WeaponCategory ).WithMany( e => e.Weapons ).HasForeignKey( e => e.WeaponCategoryId );
        builder.HasOne( e => e.WeaponType ).WithMany( e => e.Weapons ).HasForeignKey( e => e.WeaponTypeId );
        builder.HasOne( e => e.BaseAbilityScore ).WithMany( e => e.Weapons ).HasForeignKey( e => e.BaseAbilityScoreId );
        //builder.HasOne( e => e.AlternativeAbilityScore ).WithMany( e => e.AlternativeAbilityScoreForWeaponProperties ).HasForeignKey( e => e.AlternativeAbilityScoreId );
        builder.HasOne( e => e.CurrencyType ).WithMany( e => e.Weapons ).HasForeignKey( e => e.CurrencyTypeId );
    }
}