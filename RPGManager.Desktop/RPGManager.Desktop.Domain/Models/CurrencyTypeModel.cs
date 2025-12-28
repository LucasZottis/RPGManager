namespace RPGManager.Desktop.Domain.Models;

public class CurrencyTypeModel
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string Abbreviation { get; set; }
}