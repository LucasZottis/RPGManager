using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.Feature;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.ClassMappers;

public class ClassFeatureEntityMapper : EntityBaseEntityMapper<ClassFeature>
{
    protected override void Map( EntityTypeBuilder<ClassFeature> builder )
    {
        builder.Property( e => e.ClassLevelId ).IsRequired();
        builder.Property( e => e.ParentClassFeatureId );
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Description ).IsRequired();

        builder.HasOne( e => e.ClassLevel ).WithMany( e => e.Features ).HasForeignKey( e => e.ClassLevelId );
        builder.HasOne( e => e.ParentFeature ).WithMany( e => e.Children ).HasForeignKey( e => e.ParentClassFeatureId );
    }
}
