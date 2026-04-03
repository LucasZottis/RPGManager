using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.WeaponMappers;

public class WeaponTypeEntityMapper : GameSystemVersionBaseEntityMapper<WeaponType>
{
    private readonly DnD521Seed _dnD521Seed;

    public WeaponTypeEntityMapper( DnD521Seed dnD521Seed )
    {
        _dnD521Seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<WeaponType> builder )
    {
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );

        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.WeaponTypes ).HasForeignKey( e => e.GameSystemVersionId );

        builder.HasData( _dnD521Seed.GetWeaponTypes() );
    }
}