namespace RPGManager.Desktop.Domain.Entities.RaceEntities.Proficiency;

public class RaceSkillProficiencyOption
{
    public Guid RaceSkillProficiencyChoiceId { get; set; }
    public Guid SkillId { get; set; }

    public bool IsExpertise { get; set; }

    public RaceSkillProficiencyChoice RaceSkillProficiencyChoice { get; set; }
    public Skill Skill { get; set; }
}