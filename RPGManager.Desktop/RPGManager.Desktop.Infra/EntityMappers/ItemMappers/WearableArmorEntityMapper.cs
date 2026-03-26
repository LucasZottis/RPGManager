using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers;

public class WearableArmorEntityMapper : IEntityTypeConfiguration<WearableArmor>
{
    public void Configure( EntityTypeBuilder<WearableArmor> builder )
    {
        builder.Property( e => e.ArmorClassAbilityScoreModifierId );
        builder.Property( e => e.BaseArmorClass ).IsRequired();
        builder.Property( e => e.AppliesAbilityModifier ).IsRequired();
        builder.Property( e => e.MaxAbilityModifier );

        builder.HasOne( e => e.ArmorClassAbilityScoreModifier ).WithMany( e => e.ArmorClassesAbilitycoreModifiers ).HasForeignKey( e => e.ArmorClassAbilityScoreModifierId );
    }
}
