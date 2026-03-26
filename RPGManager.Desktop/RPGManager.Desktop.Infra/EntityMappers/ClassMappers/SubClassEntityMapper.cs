using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.ClassMappers;

public class SubClassEntityMapper : EntityBaseEntityMapper<SubClass>
{
    protected override void Map( EntityTypeBuilder<SubClass> builder )
    {
        builder.Property( e => e.ClassId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Description ).IsRequired();

        builder.HasOne( e => e.Class ).WithMany( e => e.SubClasses ).HasForeignKey( e => e.ClassId );
    }
}
