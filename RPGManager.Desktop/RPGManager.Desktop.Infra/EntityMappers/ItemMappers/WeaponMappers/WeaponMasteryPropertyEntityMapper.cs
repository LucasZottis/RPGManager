using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.WeaponMappers;

public class WeaponMasteryPropertyEntityMapper : GameSystemVersionBaseEntityMapper<WeaponMasteryProperty>
{
    private readonly DnD521Seed _dnD521Seed;

    public WeaponMasteryPropertyEntityMapper( DnD521Seed dnD521Seed )
    {
        _dnD521Seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<WeaponMasteryProperty> builder )
    {
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Description ).IsRequired();

        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.WeaponMasteryProperties ).HasForeignKey( e => e.GameSystemVersionId );

        builder.HasData( _dnD521Seed.GetWeaponMasteryProperties() );
    }
}
