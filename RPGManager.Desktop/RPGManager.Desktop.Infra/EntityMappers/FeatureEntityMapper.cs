using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class FeatureEntityMapper : GameSystemVersionBaseEntityMapper<Feature>
{
    protected override void Map( EntityTypeBuilder<Feature> builder )
    {
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Description );
    }
}
