using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.WeaponMappers;

public class WeaponPropertyAttributeEntityMapper : IEntityTypeConfiguration<WeaponPropertyAttribute>
{
    private readonly DnD521Seed _dnD521Seed;

    public WeaponPropertyAttributeEntityMapper( DnD521Seed dnD521Seed )
    {
        _dnD521Seed = dnD521Seed;
    }

    public void Configure( EntityTypeBuilder<WeaponPropertyAttribute> builder )
    {
        builder.Property( e => e.WeaponId ).IsRequired();
        builder.Property( e => e.WeaponPropertyId ).IsRequired();
        builder.Property( e => e.AmmunitionTypeId ).IsRequired( false );

        builder.Property( e => e.NormalRange ).IsRequired( false );
        builder.Property( e => e.LongRange ).IsRequired( false );
        builder.Property( e => e.Remarks ).HasMaxLength( MaxLength.LongName ).IsRequired( false );

        builder.HasKey( e => new { e.WeaponId, e.WeaponPropertyId } );

        builder.HasOne( e => e.Weapon ).WithMany( e => e.Properties ).HasForeignKey( e => e.WeaponId );
        builder.HasOne( e => e.WeaponProperty ).WithMany( e => e.Weapons ).HasForeignKey( e => e.WeaponPropertyId );
        builder.HasOne( e => e.AmmunitionType ).WithMany( e => e.WeaponPropertyAttributes ).HasForeignKey( e => e.AmmunitionTypeId );

        builder.HasData( _dnD521Seed.GetWeaponPropertyAttributes() );
    }
}
