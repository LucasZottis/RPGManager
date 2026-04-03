using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

public class ArmorCategory : GameSystemVersionEntityBase
{
    public string Name { get; set; }
    public string? Description { get; set; }

    public ICollection<WearableArmor> WearableArmors { get; set; }
    public ICollection<ShieldArmor> ShieldArmors { get; set; }
    //public ICollection<ClassArmorCategoryProficiency> ClassesArmorTraining { get; set; }
}