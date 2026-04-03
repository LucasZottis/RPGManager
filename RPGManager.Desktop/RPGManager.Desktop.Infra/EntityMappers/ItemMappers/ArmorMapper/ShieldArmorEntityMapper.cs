using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.ArmorMapper;

public class ShieldArmorEntityMapper : ItemEntityMapper<ShieldArmor>
{
    private readonly DnD521Seed _seed;

    public ShieldArmorEntityMapper( DnD521Seed dnD521Seed )
    {
        _seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<ShieldArmor> builder )
    {
        builder.Property( e => e.ArmorClassBonus ).IsRequired();

        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.ShieldArmors ).HasForeignKey( e => e.GameSystemVersionId );
        builder.HasOne( e => e.CostCurrencyType ).WithMany( e => e.ShieldArmors ).HasForeignKey( e => e.CostCurrencyTypeId );
        builder.HasOne( e => e.ArmorCategory ).WithMany( e => e.ShieldArmors ).HasForeignKey( e => e.ArmorCategoryId );
        builder.HasOne( e => e.RequiredAbilityScore ).WithMany( e => e.ShieldArmorsRequiredAbilityScoreId ).HasForeignKey( e => e.RequiredAbilityScoreId );

        builder.HasData( _seed.GetShieldArmors() );
    }
}