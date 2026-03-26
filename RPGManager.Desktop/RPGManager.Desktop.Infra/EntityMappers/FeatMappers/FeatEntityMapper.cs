using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.Feats;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.FeatMappers;

public class FeatEntityMapper : GameSystemVersionBaseEntityMapper<Feat>
{
    protected override void Map( EntityTypeBuilder<Feat> builder )
    {
        builder.Property( e => e.FeatCategoryId ).IsRequired();
        builder.Property( e => e.Description ).IsRequired();
        builder.Property( e => e.IsRepeatable ).IsRequired();

        builder.HasOne( e => e.FeatCategory ).WithMany().HasForeignKey( e => e.FeatCategoryId );
    }
}
