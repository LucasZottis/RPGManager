using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.ArmorMapper;

public class WearableArmorEntityMapper : IEntityTypeConfiguration<WearableArmor>
{
    private readonly DnD521Seed _seed;

    public WearableArmorEntityMapper( DnD521Seed dnD521Seed )
    {
        _seed = dnD521Seed;
    }

    public void Configure( EntityTypeBuilder<WearableArmor> builder )
    {
        builder.Property( e => e.ArmorClassAbilityScoreModifierId );
        builder.Property( e => e.BaseArmorClass ).IsRequired();
        builder.Property( e => e.AppliesAbilityModifier ).IsRequired();
        builder.Property( e => e.MaxAbilityModifier );

        builder.HasOne( e => e.ArmorClassAbilityScoreModifier ).WithMany( e => e.ArmorClassesAbilitycoreModifiers ).HasForeignKey( e => e.ArmorClassAbilityScoreModifierId );
        builder.HasOne( e => e.Armor ).WithOne( e => e.WearableArmor ).HasForeignKey<WearableArmor>( e => e.Id ); // FK é o próprio Id — 1:1

        builder.HasData( _seed.GetWearableArmors() );
    }
}