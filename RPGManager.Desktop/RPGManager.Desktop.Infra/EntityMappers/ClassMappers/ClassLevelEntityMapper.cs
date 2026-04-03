//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using RPGManager.Desktop.Domain.Entities.ClassesEntities;

//namespace RPGManager.Desktop.Infra.EntityMappers.ClassMappers;

//public class ClassLevelEntityMapper : IEntityTypeConfiguration<ClassLevel>
//{
//    public void Configure( EntityTypeBuilder<ClassLevel> builder )
//    {
//        builder.Property( e => e.ClassId ).IsRequired().ValueGeneratedNever();
//        builder.Property( e => e.LevelId ).IsRequired().ValueGeneratedNever();
//        builder.Property( e => e.ProficiencyBonus ).IsRequired();

//        builder.HasKey( e => new { e.LevelId, e.ClassId } );

//        builder.HasOne( e => e.Class ).WithMany( e => e.Levels ).HasForeignKey( e => e.ClassId );
//        builder.HasOne( e => e.Level ).WithMany( e => e.ClassesLevels ).HasForeignKey( e => e.LevelId );

//    }
//}
