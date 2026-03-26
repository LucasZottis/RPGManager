using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.ClassesEntities.ToolProficiency;

public class ClassToolProficiencyChoice : EntityChoiceBase
{
    public Guid ClassId { get; set; }
    public Class Class { get; set; }
    public ICollection<ClassToolProficiencyOption>? Options { get; set; }
}