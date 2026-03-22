using RPGManager.Desktop.Domain.Entities.ClassesEntities;

namespace RPGManager.Desktop.Domain.Entities;

public class DiceType : EntityBase
{
    public string Name { get; set; }

    public byte Sides { get; set; }

    public ICollection<Class> HitDiceClasses { get; set; }
}