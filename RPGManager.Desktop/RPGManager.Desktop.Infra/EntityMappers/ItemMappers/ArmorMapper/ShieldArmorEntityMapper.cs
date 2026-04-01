using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.ArmorMapper;

public class ShieldArmorEntityMapper : IEntityTypeConfiguration<ShieldArmor>
{
    private readonly DnD521Seed _seed;

    public ShieldArmorEntityMapper( DnD521Seed dnD521Seed )
    {
        _seed = dnD521Seed;
    }

    public void Configure( EntityTypeBuilder<ShieldArmor> builder )
    {
        //builder.Property( e => e.ArmorId ).IsRequired();
        builder.Property( e => e.ArmorClassBonus ).IsRequired();

        builder.HasOne( e => e.Armor ).WithOne( e => e.Shield ).HasForeignKey<Armor>( e => e.Id );

        builder.HasData( _seed.GetShieldArmors() );
    }
}