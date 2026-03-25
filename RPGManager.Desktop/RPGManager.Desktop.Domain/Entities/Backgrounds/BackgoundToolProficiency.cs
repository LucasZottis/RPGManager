using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;

namespace RPGManager.Desktop.Domain.Entities.Backgrounds;

public class BackgroundToolProficiency
{
    public Guid BackgroundId { get; set; }
    public Guid ToolId { get; set; }

    public Background Background { get; set; }
    public Tool Tool { get; set; }
}