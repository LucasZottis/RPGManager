using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.WeaponMappers;

public class WeaponDamageEntityMapper : IEntityTypeConfiguration<WeaponDamage>
{
    private readonly DnD521Seed _dnD521Seed;

    public WeaponDamageEntityMapper( DnD521Seed dnD521Seed )
    {
        _dnD521Seed = dnD521Seed;
    }

    public void Configure( EntityTypeBuilder<WeaponDamage> builder )
    {
        builder.Property( e => e.WeaponId ).IsRequired();
        builder.Property( e => e.DamageTypeId ).IsRequired();
        builder.Property( e => e.DiceTypeId ).IsRequired();

        builder.Property( e => e.DiceQuantity ).IsRequired().HasDefaultValue( 1 );

        builder.HasKey( e => new { e.WeaponId, e.DamageTypeId, e.DiceTypeId } );

        builder.HasOne( e => e.Weapon ).WithMany( e => e.Damages ).HasForeignKey( e => e.WeaponId );
        builder.HasOne( e => e.DamageType ).WithMany( e => e.WeaponDamages ).HasForeignKey( e => e.DamageTypeId );
        builder.HasOne( e => e.DiceType ).WithMany( e => e.WeaponsDamages ).HasForeignKey( e => e.DiceTypeId );

        builder.HasData( _dnD521Seed.GetWeaponDamages() );
    }
}