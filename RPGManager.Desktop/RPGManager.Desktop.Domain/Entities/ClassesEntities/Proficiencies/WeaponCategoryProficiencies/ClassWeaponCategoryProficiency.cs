using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Domain.Entities.ClassesEntities.Proficiencies.WeaponCategoryProficiencies;

public class ClassWeaponCategoryProficiency : EntityBase
{
    public Guid ClassId { get; set; }
    public Guid WeaponCategoryId { get; set; }

    public Class Class { get; set; }
    public WeaponCategory WeaponCategory { get; set; }

    public ICollection<ClassWeaponCategoryProficiencyCondition>? Conditions { get; set; }
}