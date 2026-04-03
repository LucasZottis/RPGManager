using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponCategory : GameSystemVersionEntityBase
{
    public string Name { get; set; }

    public ICollection<Weapon> Weapons { get; set; }
    //public ICollection<ClassWeaponCategoryProficiency> ClassWeaponCategoryProficiencies { get; set; }
}