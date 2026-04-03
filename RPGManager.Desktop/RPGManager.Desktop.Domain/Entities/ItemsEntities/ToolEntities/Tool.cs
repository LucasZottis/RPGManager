namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;

public class Tool : Item
{
    public Guid ToolCategoryId { get; set; }
    public Guid CheckAbilityScoreId { get; set; }

    public string Utilize { get; set; }
    public string? Craft { get; set; }
    public string? Variants { get; set; }

    public AbilityScore Ability { get; set; }
    public ToolCategory ToolCateogry { get; set; }
}