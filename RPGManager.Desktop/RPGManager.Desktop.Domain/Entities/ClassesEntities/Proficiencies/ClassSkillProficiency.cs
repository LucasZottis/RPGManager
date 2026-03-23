namespace RPGManager.Desktop.Domain.Entities.ClassesEntities.Proficiencies;

public class ClassSkillProficiency
{
    public Guid ClassId { get; set; }
    public Guid SkillId { get; set; }

    public Class Class { get; set; }
    public Skill Skill { get; set; }
}