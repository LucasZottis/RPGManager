using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.WeaponMappers;

public class WeaponPropertiesWeaponsEntityMapper : IEntityTypeConfiguration<WeaponPropertyAttribute>
{
    public void Configure( EntityTypeBuilder<WeaponPropertyAttribute> builder )
    {
        builder.Property( e => e.WeaponId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.WeaponPropertyId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.AmmunitionTypeId );
        builder.Property( e => e.NormalRange );
        builder.Property( e => e.LongRange );
        builder.Property( e => e.Remarks ).HasMaxLength( MaxLength.LongName );

        builder.HasKey( e => new { e.WeaponId, e.WeaponPropertyId } );

        builder.HasOne( e => e.Weapon ).WithMany( e => e.Properties ).HasForeignKey( e => e.WeaponId );
        builder.HasOne( e => e.WeaponProperty ).WithMany( e => e.Weapons ).HasForeignKey( e => e.WeaponPropertyId );
        builder.HasOne( e => e.AmmunitionType ).WithMany( e => e.WeaponPropertyAttributes ).HasForeignKey( e => e.AmmunitionTypeId );
    }
}
