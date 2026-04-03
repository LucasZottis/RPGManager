using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities;

public class Skill : GameSystemVersionEntityBase
{
    public Guid BaseAbilityScoreId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public AbilityScore BaseAbilityScore { get; set; }

    //public ICollection<ClassSkillProficiencyOption> ClassSkillProficiencies { get; set; }
}