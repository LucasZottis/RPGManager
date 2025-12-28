using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

namespace RPGManager.Desktop.Domain.Entities.RaceEntities;

public class RaceArmorProficiency
{
    public Guid RaceId { get; set; }
    public Guid ArmorCategoryId { get; set; }

    public Race Race { get; set; }
    public ArmorCategory ArmorCategory { get; set; }
}