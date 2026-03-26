using RPGManager.Desktop.Domain.Entities.Base;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.SkillProficiency;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.ToolProficiency;

namespace RPGManager.Desktop.Domain.Entities.ClassesEntities;

public class ClassBase : EntityBase
{
    public string Name { get; set; }

    public ICollection<ClassLevel> Levels { get; set; }
    public ICollection<ClassSpell>? Spells { get; set; }
    public ICollection<ClassSkillProficiencyChoice>? SkillProficiencyChoice { get; set; }
    public ICollection<ClassToolProficiencyChoice>? ToolProficiencyChoice { get; set; }
}