//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using RPGManager.Desktop.Domain.Entities.ClassesEntities.Feature;

//namespace RPGManager.Desktop.Infra.EntityMappers.ClassMappers;

//public class ClassFeatureAttributeLevelEntityMapper : IEntityTypeConfiguration<ClassFeatureAttributeLevel>
//{
//    public void Configure( EntityTypeBuilder<ClassFeatureAttributeLevel> builder )
//    {
//        builder.Property( e => e.ClassFeatureAttributeId ).IsRequired().ValueGeneratedNever();
//        builder.Property( e => e.DiceTypeId );
//        builder.Property( e => e.Value ).IsRequired();

//        builder.HasKey( e => new { e.ClassFeatureAttributeId, e.ClassId, e.LevelId } );

//        builder.HasOne( e => e.ClassLevel )
//                       .WithMany( e => e.AttributeLevels )
//                       .HasForeignKey( e => new { e.LevelId, e.ClassId } )
//                       .HasPrincipalKey( e => new { e.LevelId, e.ClassId } );

//        builder.HasOne( e => e.ClassFeatureAttribute )
//               .WithMany( e => e.AttributeLevels )
//               .HasForeignKey( e => e.ClassFeatureAttributeId );

//        builder.HasOne( e => e.DiceType ).WithMany( e => e.ClassFeatureAttributeLevels ).HasForeignKey( e => e.DiceTypeId );
//    }
//}
