using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Domain.Entities.ClassesEntities;

public class ClassWeaponCategoryProficiencyCondition
{
    public Guid ClassId { get; set; }
    public Guid WeaponCategoryId { get; set; }
    public Guid WeaponPropertyId { get; set; }

    public Class Class { get; set; }
    public WeaponCategory WeaponCategory { get; set; }
    public WeaponProperty WeaponProperty { get; set; }
}