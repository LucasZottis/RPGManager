using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.RaceEntities.Proficiency;

public class RaceSkillProficiencyChoice : EntityChoiceBase
{
    public Guid RaceId { get; set; }
    public Race Race { get; set; }
    public ICollection<RaceSkillProficiencyOption> Options { get; set; }
}