using RPGManager.Desktop.Domain.Entities.ClassesEntities.Proficiencies.WeaponCategoryProficiencies;

namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponCategory : GameSystemEntityBase
{
    public string Name { get; set; }

    public ICollection<Weapon> Weapons { get; set; }
    public ICollection<ClassWeaponCategoryProficiency> ClassWeaponCategoryProficiencies { get; set; }
}