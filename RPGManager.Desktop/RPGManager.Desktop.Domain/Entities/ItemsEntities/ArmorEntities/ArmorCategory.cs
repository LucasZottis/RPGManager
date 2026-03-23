using RPGManager.Desktop.Domain.Entities.ClassesEntities.Proficiencies;

namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

public class ArmorCategory : GameSystemEntityBase
{
    public string Name { get; set; }
    public string? Description { get; set; }

    public ICollection<ClassArmorCategoryProficiency> ClassesArmorTraining { get; set; }
}