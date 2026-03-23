namespace RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;

public class CurrencyConversionRate
{
    public Guid FromCurrencyTypeId { get; set; }
    public Guid ToCurrencyTypeId { get; set; }
    public decimal Rate { get; set; } // 100 CP = 1 GP → Rate = 100

    public CurrencyType FromCurrencyType { get; set; }
    public CurrencyType ToCurrencyType { get; set; }
}