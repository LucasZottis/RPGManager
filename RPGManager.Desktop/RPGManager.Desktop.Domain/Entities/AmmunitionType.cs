using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Domain.Entities;

public class AmmunitionType : GameSystemEntityBase
{
    public Guid CostCurrencyTypeId { get; set; }

    public string Name { get; set; }
    public byte Amount { get; set; }
    public string Storage { get; set; }
    public float Weight { get; set; }
    public decimal Cost { get; set; }

    public CurrencyType CostCurrencyType { get; set; }

    public ICollection<WeaponPropertyAttribute> WeaponPropertyAttributes { get; set; }
}