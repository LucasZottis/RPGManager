using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.WeaponProficiency;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.ClassMappers;

public class ClassWeaponCategoryProficiencyEntityMapper : EntityBaseEntityMapper<ClassWeaponCategoryProficiency>
{
    protected override void Map( EntityTypeBuilder<ClassWeaponCategoryProficiency> builder )
    {
        builder.Property( e => e.ClassId ).IsRequired();
        builder.Property( e => e.WeaponCategoryId ).IsRequired();

        builder.HasOne( e => e.Class ).WithMany( e => e.WeaponProficiencies ).HasForeignKey( e => e.ClassId );
        builder.HasOne( e => e.WeaponCategory ).WithMany().HasForeignKey( e => e.WeaponCategoryId );
    }
}
