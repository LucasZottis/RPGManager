namespace RPGManager.Desktop.Domain.Models.Items.Gears;

public class GearRegisterDto
{
    public Guid GameSystemId { get; set; }
    public Guid? CostCurrencyTypeId { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public float? Weight { get; set; }
    public string Description { get; set; }
}
