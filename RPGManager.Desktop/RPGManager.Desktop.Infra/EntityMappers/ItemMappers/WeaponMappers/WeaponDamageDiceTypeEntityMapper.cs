using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.WeaponMappers;

public class WeaponDamageDiceTypeEntityMapper : IEntityTypeConfiguration<WeaponDamageDiceType>
{
    public void Configure( EntityTypeBuilder<WeaponDamageDiceType> builder )
    {
        builder.Property( e => e.WeaponDamageId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.DiceTypeId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.Quantity ).IsRequired();

        builder.HasKey( e => new { e.WeaponDamageId, e.DiceTypeId } );

        builder.HasOne( e => e.WeaponDamage ).WithMany( e => e.DamageDiceTypes ).HasForeignKey( e => e.WeaponDamageId );
        builder.HasOne( e => e.DiceType ).WithMany( e => e.WeaponsDamages ).HasForeignKey( e => e.DiceTypeId );
    }
}
