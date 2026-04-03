using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.GearMappers;

public class GearEntityMapper : ItemEntityMapper<Gear>
{
    private readonly DnD521Seed _dnD521Seed;

    public GearEntityMapper( DnD521Seed dnD521Seed )
    {
        _dnD521Seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder <Gear> builder )
    {
        builder.Property( e => e.Description ).IsRequired();

        builder.HasData( _dnD521Seed.GetGears() );
    }
}