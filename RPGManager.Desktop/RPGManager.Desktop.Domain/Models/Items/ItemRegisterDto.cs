namespace RPGManager.Desktop.Domain.Models.Items;

public class ItemRegisterDto
{
    public Guid GameSystemId { get; set; }
    public Guid? CostCurrencyTypeId { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public float? Weight { get; set; }
}
