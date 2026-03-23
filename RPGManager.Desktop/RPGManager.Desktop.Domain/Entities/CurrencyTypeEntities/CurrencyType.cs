using RPGManager.Desktop.Domain.Entities.ClassesEntities.StartingEquipment;
using RPGManager.Desktop.Domain.Entities.ItemsEntities;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;

public class CurrencyType : GameSystemEntityBase
{
    public string Name { get; set; }
    public string? Abbreviation { get; set; }
    public bool IsBaseCurrency { get; set; }

    public ICollection<CurrencyConversionRate> FromCurrencyRates { get; set; }
    public ICollection<CurrencyConversionRate> ToCurrencyRates { get; set; }
    public ICollection<ClassStartingEquipmentItem> ClassesStartingEquipmentItems { get; set; }
    public ICollection<Item> Items { get; set; }
    public ICollection<AmmunitionType> AmmunitionTypes { get; set; }
}