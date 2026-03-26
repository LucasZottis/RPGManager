using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.ClassMappers;

public class ClassArmorCategoryProficiencyEntityMapper : IEntityTypeConfiguration<ClassArmorCategoryProficiency>
{
    public void Configure( EntityTypeBuilder<ClassArmorCategoryProficiency> builder )
    {
        builder.Property( e => e.ClassId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.ArmorCategoryId ).IsRequired().ValueGeneratedNever();

        builder.HasKey( e => new { e.ClassId, e.ArmorCategoryId } );

        builder.HasOne( e => e.Class ).WithMany( e => e.ArmorTraining ).HasForeignKey( e => e.ClassId );
        builder.HasOne( e => e.ArmorCategory ).WithMany( e => e.ClassesArmorTraining ).HasForeignKey( e => e.ArmorCategoryId );
    }
}
