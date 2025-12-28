namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;

public class Tool : EntityBase
{
    public Guid GameSystemId { get; set; }
    public Guid? ToolCategoryId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }

    public GameSystem GameSystem { get; set; }
}