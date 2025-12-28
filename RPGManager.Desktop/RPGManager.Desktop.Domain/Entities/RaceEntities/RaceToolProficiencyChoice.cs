using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;

namespace RPGManager.Desktop.Domain.Entities.RaceEntities;

public class RaceToolProficiencyChoice
{
    public Guid RaceProficiencyChoiceId { get; set; }
    public Guid ToolId { get; set; }

    public RaceProficiencyChoice RaceProficiencyChoice { get; set; }
    public Tool Tool { get; set; }
}