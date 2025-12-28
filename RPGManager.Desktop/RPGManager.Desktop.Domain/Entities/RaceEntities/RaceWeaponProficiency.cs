using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Domain.Entities.RaceEntities;

public class RaceWeaponProficiency
{
    public Guid RaceId { get; set; }
    public Guid WeaponId { get; set; }

    public Race Race { get; set; }

    public Weapon Weapon { get; set; }
}