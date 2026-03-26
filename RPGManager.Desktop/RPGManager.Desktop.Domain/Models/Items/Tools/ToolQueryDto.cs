namespace RPGManager.Desktop.Domain.Models.Items.Tools;

public class ToolQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public Guid? CostCurrencyTypeId { get; set; }
    public Guid? CheckAbilityScoreId { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public float? Weight { get; set; }
    public string? Description { get; set; }
}
