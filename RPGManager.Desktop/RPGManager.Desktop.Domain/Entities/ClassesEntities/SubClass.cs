using RPGManager.Desktop.Domain.Entities.ClassesEntities.SkillProficiency;

namespace RPGManager.Desktop.Domain.Entities.ClassesEntities;

public class SubClass : ClassBase
{
    public Guid ClassId { get; set; }

    public string Description { get; set; }

    public Class Class { get; set; }
}