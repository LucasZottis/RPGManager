using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.GearMappers.ToolMappers;

public class ToolEntityMapper : ItemEntityMapper<Tool>
{
    private readonly DnD521Seed _dnD521Seed;

    public ToolEntityMapper( DnD521Seed dnD521Seed )
    {
        _dnD521Seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<Tool> builder )
    {
        builder.Property( e => e.ToolCategoryId ).IsRequired();
        builder.Property( e => e.CheckAbilityScoreId ).IsRequired();

        builder.Property( e => e.Utilize ).IsRequired();
        builder.Property( e => e.Craft ).IsRequired( false );
        builder.Property( e => e.Variants ).IsRequired( false );

        builder.HasOne( e => e.Ability ).WithMany( e => e.ToolsCheck ).HasForeignKey( e => e.CheckAbilityScoreId );
        builder.HasOne( e => e.ToolCateogry ).WithMany( e => e.Tools ).HasForeignKey( e => e.ToolCategoryId );
        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.Tools ).HasForeignKey( e => e.GameSystemVersionId );
        builder.HasOne( e => e.CostCurrencyType ).WithMany( e => e.Tools ).HasForeignKey( e => e.CostCurrencyTypeId );

        builder.HasData( _dnD521Seed.GetTools() );
    }
}