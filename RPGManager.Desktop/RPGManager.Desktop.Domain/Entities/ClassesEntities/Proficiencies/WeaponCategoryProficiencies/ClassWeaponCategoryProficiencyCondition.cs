using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Domain.Entities.ClassesEntities.Proficiencies.WeaponCategoryProficiencies;

public class ClassWeaponCategoryProficiencyCondition
{
    public Guid ClassWeaponCategoryProficiencyId { get; set; }
    public Guid WeaponPropertyId { get; set; }

    public WeaponProperty WeaponProperty { get; set; }
}