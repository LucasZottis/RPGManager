using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;

namespace RPGManager.Desktop.Domain.Entities.RaceEntities;

public class RaceToolProficiency
{
    public Guid RaceId { get; set; }
    public Guid ToolId { get; set; }

    public Race Race { get; set; }

    public Tool Tool { get; set; }
}