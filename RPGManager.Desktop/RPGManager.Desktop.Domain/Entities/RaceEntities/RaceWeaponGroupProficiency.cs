using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Domain.Entities.RaceEntities;

public class RaceWeaponGroupProficiency
{
    public Guid RaceId { get; set; }
    public Guid WeaponTypeId { get; set; }

    public Race Race { get; set; }

    public WeaponType WeaponType { get; set; }
}