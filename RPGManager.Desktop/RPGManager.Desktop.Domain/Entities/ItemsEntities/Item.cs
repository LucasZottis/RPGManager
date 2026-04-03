namespace RPGManager.Desktop.Domain.Entities.ItemsEntities;

public abstract class Item : GameSystemVersionEntityBase
{
    public Guid? CostCurrencyTypeId { get; set; }

    public string Name { get; set; }
    public decimal Cost { get; set; }
    public float? Weight { get; set; }

    public CurrencyType? CostCurrencyType { get; set; }
}