using RPGManager.Desktop.Domain.Entities.Base;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.Feature;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Domain.Entities;

public class DiceType : EntityBase
{
    public string Name { get; set; }

    public byte Sides { get; set; }

    public ICollection<Class> HitDiceClasses { get; set; }
    public ICollection<WeaponDamageDiceType> WeaponsDamages { get; set; }
    public ICollection<ClassFeatureAttributeLevel> ClassFeatureAttributeLevels { get; set; }
}