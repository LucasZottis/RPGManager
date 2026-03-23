using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

namespace RPGManager.Desktop.Domain.Entities.ClassesEntities.Proficiencies;

public class ClassArmorCategoryProficiency
{
    public Guid ClassId { get; set; }
    public Guid ArmorCategoryId { get; set; }

    public Class Class { get; set; }
    public ArmorCategory ArmorCategory { get; set; }
}