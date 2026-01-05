using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Infra.Db.EntityMappers.WeaponMappers;

public class WeaponPropertiesWeaponsEntityMapper : IEntityTypeConfiguration<WeaponProperties>
{
    public void Configure( EntityTypeBuilder<WeaponProperties> builder )
    {
        builder.Property( e => e.WeaponPropertyId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.WeaponId ).IsRequired().ValueGeneratedNever();

        builder.HasKey( e => new { e.WeaponPropertyId, e.WeaponId } );

        builder.HasOne( e => e.Weapon ).WithMany( e => e.WeaponProperties ).HasForeignKey( e => e.WeaponId );
        builder.HasOne( e => e.WeaponProperty ).WithMany( e => e.Weapons ).HasForeignKey( e => e.WeaponPropertyId );
    }
}