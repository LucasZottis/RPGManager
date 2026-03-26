using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponMasteryProperty : GameSystemVersionEntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
}