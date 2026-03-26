using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.Feature;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.ClassMappers;

public class ClassFeatureAttributeEntityMapper : EntityBaseEntityMapper<ClassFeatureAttribute>
{
    protected override void Map( EntityTypeBuilder<ClassFeatureAttribute> builder )
    {
        builder.Property( e => e.ClassFeatureId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );

        builder.HasOne( e => e.ClassFeature ).WithMany( e => e.Attributes ).HasForeignKey( e => e.ClassFeatureId );
    }
}
