namespace RPGManager.Desktop.Domain.DTOs.Items;

public class ItemQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public Guid? CostCurrencyTypeId { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public float? Weight { get; set; }
}
