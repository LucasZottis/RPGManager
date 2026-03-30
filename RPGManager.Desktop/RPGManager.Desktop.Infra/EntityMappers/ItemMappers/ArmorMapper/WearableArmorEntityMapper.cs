using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.ArmorMapper;

public class WearableArmorEntityMapper : IEntityTypeConfiguration<WearableArmor>
{
    public void Configure( EntityTypeBuilder<WearableArmor> builder )
    {
        builder.Property( e => e.ArmorClassAbilityScoreModifierId );
        builder.Property( e => e.BaseArmorClass ).IsRequired();
        builder.Property( e => e.AppliesAbilityModifier ).IsRequired();
        builder.Property( e => e.MaxAbilityModifier );

        builder.HasOne( e => e.ArmorClassAbilityScoreModifier ).WithMany( e => e.ArmorClassesAbilitycoreModifiers ).HasForeignKey( e => e.ArmorClassAbilityScoreModifierId );

        builder.ToTable( nameof( WearableArmor ).ToLower(), $"pk_{nameof( WearableArmor ).ToLower()}" ); // tabela separada de Item

        builder.HasOne<Armor>()
           .WithOne( e => e.WearableArmor ) // precisa adicionar Tool em Item
           .HasForeignKey<WearableArmor>( e => e.Id ); // FK é o próprio Id — 1:1
    }
}
