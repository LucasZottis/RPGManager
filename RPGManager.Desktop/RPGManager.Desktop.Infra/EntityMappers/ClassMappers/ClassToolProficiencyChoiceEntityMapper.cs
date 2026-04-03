//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using RPGManager.Desktop.Domain.Entities.ClassesEntities;
//using RPGManager.Desktop.Domain.Entities.ClassesEntities.ToolProficiency;
//using RPGManager.Desktop.Infra.EntityMappers.Base;

//namespace RPGManager.Desktop.Infra.EntityMappers.ClassMappers;

//public class ClassToolProficiencyChoiceEntityMapper : EntityChoiceBaseEntityMapper<ClassToolProficiencyChoice>
//{
//    protected override void Map( EntityTypeBuilder<ClassToolProficiencyChoice> builder )
//    {
//        builder.Property( e => e.ClassId ).IsRequired();

//        builder.HasOne( e => e.Class ).WithMany( e => e.ToolProficiencyChoice ).HasForeignKey( e => e.ClassId );
//    }
//}
