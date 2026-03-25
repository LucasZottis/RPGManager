using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.Backgrounds.ToolProficiencies;

public class BackgroundToolProficiencyChoice : EntityChoiceBase
{
    public Guid BackgroundId { get; set; }

    public Background Background { get; set; }

    public ICollection<BackgroundToolProficiencyOption> Options { get; set; }
}