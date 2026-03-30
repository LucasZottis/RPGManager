using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.WeaponMappers;

public class WeaponDamageEntityMapper : EntityBaseEntityMapper<WeaponDamage>
{
    protected override void Map( EntityTypeBuilder<WeaponDamage> builder )
    {
        builder.Property( e => e.WeaponId ).IsRequired();
        builder.Property( e => e.DamageTypeId ).IsRequired();

        builder.HasOne( e => e.Weapon ).WithMany( e => e.Damages ).HasForeignKey( e => e.WeaponId );
        builder.HasOne( e => e.DamageType ).WithMany().HasForeignKey( e => e.DamageTypeId );
    }
}
