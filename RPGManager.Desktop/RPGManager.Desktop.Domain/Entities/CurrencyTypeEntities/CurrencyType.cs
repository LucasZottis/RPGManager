using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;

namespace RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;

public class CurrencyType : GameSystemVersionEntityBase
{
    public string Name { get; set; }
    public string? Abbreviation { get; set; }
    public bool IsBaseCurrency { get; set; }

    public ICollection<AmmunitionType> AmmunitionTypes { get; set; }
    public ICollection<CurrencyConversionRate> FromCurrencyRates { get; set; }
    public ICollection<CurrencyConversionRate> ToCurrencyRates { get; set; }
    //public ICollection<ClassStartingEquipmentItem> ClassesStartingEquipmentItems { get; set; }
    public ICollection<ShieldArmor> ShieldArmors { get; set; }
    public ICollection<Tool> Tools { get; set; }
    public ICollection<WearableArmor> WearableArmors { get; set; }
    public ICollection<Weapon> Weapons { get; set; }
}