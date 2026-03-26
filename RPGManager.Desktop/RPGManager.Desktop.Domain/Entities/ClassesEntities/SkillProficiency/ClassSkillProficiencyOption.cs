namespace RPGManager.Desktop.Domain.Entities.ClassesEntities.SkillProficiency;

public class ClassSkillProficiencyOption
{
    public Guid ClassSkillProficiencyChoiceId { get; set; }
    public Guid SkillId { get; set; }

    public ClassSkillProficiencyChoice ClassSkillProficiencyChoice { get; set; }
    public Skill Skill { get; set; }
}