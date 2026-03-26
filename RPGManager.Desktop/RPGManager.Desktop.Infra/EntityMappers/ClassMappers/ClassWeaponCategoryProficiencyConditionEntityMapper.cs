using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.WeaponProficiency;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.ClassMappers;

public class ClassWeaponCategoryProficiencyConditionEntityMapper : IEntityTypeConfiguration<ClassWeaponCategoryProficiencyCondition>
{
    public void Configure( EntityTypeBuilder<ClassWeaponCategoryProficiencyCondition> builder )
    {
        builder.Property( e => e.ClassWeaponCategoryProficiencyId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.WeaponPropertyId ).IsRequired().ValueGeneratedNever();

        builder.HasKey( e => new { e.ClassWeaponCategoryProficiencyId, e.WeaponPropertyId } );

        builder.HasOne<ClassWeaponCategoryProficiency>().WithMany( e => e.Conditions ).HasForeignKey( e => e.ClassWeaponCategoryProficiencyId );
        builder.HasOne( e => e.WeaponProperty ).WithMany().HasForeignKey( e => e.WeaponPropertyId );
    }
}
