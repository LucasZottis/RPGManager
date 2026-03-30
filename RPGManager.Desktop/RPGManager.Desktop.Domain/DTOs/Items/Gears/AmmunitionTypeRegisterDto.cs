namespace RPGManager.Desktop.Domain.DTOs.Items.Gears;

public class AmmunitionTypeRegisterDto
{
    public Guid GameSystemId { get; set; }
    public Guid? CostCurrencyTypeId { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public float? Weight { get; set; }
    public string Description { get; set; }
    public byte Amount { get; set; }
    public string Storage { get; set; }
}
