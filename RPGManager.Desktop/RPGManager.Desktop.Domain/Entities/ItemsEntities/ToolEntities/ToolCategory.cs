namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;

public class ToolCategory : GameSystemVersionEntityBase
{
    public string Name { get; set; }
    public ICollection<Tool> Tools { get; set; }
}