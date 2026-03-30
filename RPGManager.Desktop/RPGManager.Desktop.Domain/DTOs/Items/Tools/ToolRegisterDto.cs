namespace RPGManager.Desktop.Domain.DTOs.Items.Tools;

public class ToolRegisterDto
{
    public Guid GameSystemId { get; set; }
    public Guid? CostCurrencyTypeId { get; set; }
    public Guid? CheckAbilityScoreId { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public float? Weight { get; set; }
    public string? Description { get; set; }
}
