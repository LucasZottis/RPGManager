using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.WeaponMappers;

public class WeaponEntityMapper : ItemEntityMapper<Weapon>
{
    private readonly DnD521Seed _dnD521Seed;

    public WeaponEntityMapper( DnD521Seed dnD521Seed )
    {
        _dnD521Seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<Weapon> builder )
    {
        builder.Property( e => e.WeaponCategoryId ).IsRequired();
        builder.Property( e => e.WeaponTypeId ).IsRequired();
        builder.Property( e => e.WeaponMasteryPropertyId ).IsRequired();
        builder.Property( e => e.BaseAbilityScoreId ).IsRequired();

        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.Weapons ).HasForeignKey( e => e.GameSystemVersionId );
        builder.HasOne( e => e.CostCurrencyType ).WithMany( e => e.Weapons ).HasForeignKey( e => e.CostCurrencyTypeId );
        builder.HasOne( e => e.WeaponCategory ).WithMany( e => e.Weapons ).HasForeignKey( e => e.WeaponCategoryId );
        builder.HasOne( e => e.WeaponType ).WithMany( e => e.Weapons ).HasForeignKey( e => e.WeaponTypeId );
        builder.HasOne( e => e.WeaponMasteryProperty ).WithMany().HasForeignKey( e => e.WeaponMasteryPropertyId );
        builder.HasOne( e => e.BaseAbilityScore ).WithMany( e => e.Weapons ).HasForeignKey( e => e.BaseAbilityScoreId );

        builder.HasData( _dnD521Seed.GetWeapons() );
    }
}