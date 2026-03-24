using RPGManager.Desktop.Domain.Entities.ClassesEntities.StartingEquipment;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.WeaponProficiency;

namespace RPGManager.Desktop.Domain.Entities.ClassesEntities;

public class Class : ClassBase
{
    public Guid GameSystemId { get; set; }
    public Guid PrimaryAbilityScoreId { get; set; }
    public Guid HitDiceTypeId { get; set; }

    public string Name { get; set; }

    public DiceType HitDiceType { get; set; }
    public AbilityScore PrimaryAbilityScore { get; set; }
    public GameSystem GameSystem { get; set; }

    public ICollection<SubClass> SubClasses { get; set; }
    public ICollection<ClassLevel> Levels { get; set; }
    public ICollection<ClassSavingThrowProficiency> SavingThrowProficiencies { get; set; }
    public ICollection<ClassWeaponCategoryProficiency> WeaponProficiencies { get; set; }
    public ICollection<ClassArmorCategoryProficiency> ArmorTraining { get; set; }
    public ICollection<ClassStartingEquipmentChoice> StartingEquipmentChoice { get; set; }    
}