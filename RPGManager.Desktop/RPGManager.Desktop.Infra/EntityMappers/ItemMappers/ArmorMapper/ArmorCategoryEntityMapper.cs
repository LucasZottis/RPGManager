using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.ArmorMapper;

public class ArmorCategoryEntityMapper : GameSystemVersionBaseEntityMapper<ArmorCategory>
{
    private readonly DnD521Seed _seed;

    public ArmorCategoryEntityMapper(DnD521Seed dnD521Seed)
    {
        _seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<ArmorCategory> builder )
    {
        builder.Property(e => e.GameSystemVersionId).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Description );

        builder.HasOne(e => e.GameSystemVersion).WithMany(e =>e.ArmorCategories ).HasForeignKey(e => e.GameSystemVersionId);

        builder.HasData( _seed.GetArmorCategories() );
    }
}
