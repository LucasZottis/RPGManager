using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.ArmorMapper;

public class WearableArmorEntityMapper : ArmorEntityMapper<WearableArmor>
{
    private readonly DnD521Seed _seed;

    public WearableArmorEntityMapper( DnD521Seed dnD521Seed )
    {
        _seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<WearableArmor> builder )
    {
        builder.Property( e => e.ArmorClassAbilityScoreModifierId ).IsRequired( false );

        builder.Property( e => e.BaseArmorClass ).IsRequired();
        builder.Property( e => e.AppliesAbilityModifier ).IsRequired();
        builder.Property( e => e.MaxAbilityModifier );

        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.WearableArmors ).HasForeignKey( e => e.GameSystemVersionId );
        builder.HasOne( e => e.CostCurrencyType ).WithMany( e => e.WearableArmors ).HasForeignKey( e => e.CostCurrencyTypeId );
        builder.HasOne( e => e.ArmorCategory ).WithMany( e => e.WearableArmors ).HasForeignKey( e => e.ArmorCategoryId );
        builder.HasOne( e => e.RequiredAbilityScore ).WithMany( e => e.WearableArmorsRequiredAbilityScoreId ).HasForeignKey( e => e.RequiredAbilityScoreId );
        builder.HasOne( e => e.ArmorClassAbilityScoreModifier ).WithMany( e => e.WearableArmorClassesAbilitycoreModifiers ).HasForeignKey( e => e.ArmorClassAbilityScoreModifierId );

        builder.HasData( _seed.GetWearableArmors() );
    }
}