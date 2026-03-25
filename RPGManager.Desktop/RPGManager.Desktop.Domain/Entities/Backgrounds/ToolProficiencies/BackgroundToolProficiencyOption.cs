using RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;

namespace RPGManager.Desktop.Domain.Entities.Backgrounds.ToolProficiencies;

public class BackgroundToolProficiencyOption
{
    public Guid BackgroundToolProficiencyChoiceId { get; set; }
    public Guid GearId { get; set; }

    public BackgroundToolProficiencyChoice BackgroundToolProficiencyChoice { get; set; }
    public Gear Gear { get; set; }
}