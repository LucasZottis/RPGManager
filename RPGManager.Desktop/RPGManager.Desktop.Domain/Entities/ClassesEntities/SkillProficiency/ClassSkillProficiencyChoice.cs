using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.ClassesEntities.SkillProficiency;

public class ClassSkillProficiencyChoice : EntityChoiceBase
{
    public Guid ClassId { get; set; }
    public Class Class { get; set; }

    public ICollection<ClassSkillProficiencyOption> Options { get; set; }
}