using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.GearMappers.ToolMappers;

public class ToolCategoryEntityMapper : GameSystemVersionBaseEntityMapper<ToolCategory>
{
    private readonly DnD521Seed _dnD521Seed;

    public ToolCategoryEntityMapper( DnD521Seed dnD521Seed )
    {
        _dnD521Seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<ToolCategory> builder )
    {
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.ToolCategories ).HasForeignKey( e => e.GameSystemVersionId );

        builder.HasData( _dnD521Seed.GetToolCategories() );
    }
}