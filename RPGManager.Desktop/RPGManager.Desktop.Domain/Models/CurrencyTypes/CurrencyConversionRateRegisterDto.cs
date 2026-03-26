namespace RPGManager.Desktop.Domain.Models.CurrencyTypes;

public class CurrencyConversionRateRegisterDto
{
    public Guid FromCurrencyTypeId { get; set; }
    public Guid ToCurrencyTypeId { get; set; }
    public decimal Rate { get; set; }
}
