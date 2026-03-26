using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.StartingEquipment;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.ClassMappers;

public class ClassStartingEquipmentChoiceEntityMapper : EntityBaseEntityMapper<ClassStartingEquipmentChoice>
{
    protected override void Map( EntityTypeBuilder<ClassStartingEquipmentChoice> builder )
    {
        builder.Property( e => e.ClassId ).IsRequired();
        builder.Property( e => e.OptionOrder ).IsRequired();

        builder.HasOne( e => e.Class ).WithMany( e => e.StartingEquipmentChoice ).HasForeignKey( e => e.ClassId );
    }
}
