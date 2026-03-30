namespace RPGManager.Desktop.Domain.DTOs.CurrencyTypes;

public class CurrencyConversionRateRegisterDto
{
    public Guid FromCurrencyTypeId { get; set; }
    public Guid ToCurrencyTypeId { get; set; }
    public decimal Rate { get; set; }
}
