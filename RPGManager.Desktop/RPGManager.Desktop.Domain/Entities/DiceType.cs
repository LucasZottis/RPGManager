namespace RPGManager.Desktop.Domain.Entities;

public class DiceType : EntityBase
{
    public string Name { get; set; }

    public byte Sides { get; set; }

    //public ICollection<Class> HitDiceClasses { get; set; }
    public ICollection<WeaponDamage> WeaponsDamages { get; set; }
    //public ICollection<ClassFeatureAttributeLevel> ClassFeatureAttributeLevels { get; set; }
}