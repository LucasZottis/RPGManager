using RPGManager.Desktop.Domain.Entities.ClassesEntities.Proficiencies;

namespace RPGManager.Desktop.Domain.Entities;

public class Skill : GameSystemEntityBase
{
    public Guid BaseAbilityScoreId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public AbilityScore BaseAbilityScore { get; set; }

    public ICollection<ClassSkillProficiency> ClassSkillProficiencies { get; set; }
}