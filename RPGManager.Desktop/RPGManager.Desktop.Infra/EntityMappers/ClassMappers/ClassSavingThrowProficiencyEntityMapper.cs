using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.ClassMappers;

public class ClassSavingThrowProficiencyEntityMapper : IEntityTypeConfiguration<ClassSavingThrowProficiency>
{
    public void Configure( EntityTypeBuilder<ClassSavingThrowProficiency> builder )
    {
        builder.Property( e => e.ClassId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.AbilityScoreId ).IsRequired().ValueGeneratedNever();

        builder.HasKey( e => new { e.ClassId, e.AbilityScoreId } );

        builder.HasOne( e => e.Class ).WithMany( e => e.SavingThrowProficiencies ).HasForeignKey( e => e.ClassId );
        builder.HasOne( e => e.AbilityScore ).WithMany( e => e.ClassSavingThrowProficiencies ).HasForeignKey( e => e.AbilityScoreId );
    }
}
