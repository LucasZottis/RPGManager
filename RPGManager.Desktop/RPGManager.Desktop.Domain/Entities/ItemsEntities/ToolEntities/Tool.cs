namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;

public class Tool : Item
{
    //public Guid? ToolCategoryId { get; set; }
    public Guid? CheckAbilityScoreId { get; set; }

    public string Name { get; set; }
    public string? Description { get; set; }

    public AbilityScore Ability { get; set; }
}