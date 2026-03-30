namespace RPGManager.Desktop.Domain.DTOs.CurrencyTypes;

public class CurrencyTypeQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Abbreviation { get; set; }
    public bool IsBaseCurrency { get; set; }
}
