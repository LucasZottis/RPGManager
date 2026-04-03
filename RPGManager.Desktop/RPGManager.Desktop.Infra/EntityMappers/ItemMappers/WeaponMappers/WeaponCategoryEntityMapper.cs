using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.WeaponMappers;

public class WeaponCategoryEntityMapper : GameSystemVersionBaseEntityMapper<WeaponCategory>
{
    private readonly DnD521Seed _dnD521Seed;

    public WeaponCategoryEntityMapper( DnD521Seed dnD521Seed )
    {
        _dnD521Seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<WeaponCategory> builder )
    {
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );

        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.WeaponCategories ).HasForeignKey( e => e.GameSystemVersionId );

        builder.HasData( _dnD521Seed.GetWeaponCategories() );
    }
}