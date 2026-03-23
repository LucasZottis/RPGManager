using RPGManager.Desktop.Domain.Entities.ClassesEntities.Feature;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.Proficiencies;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.Proficiencies.WeaponCategoryProficiencies;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.StartingEquipment;

namespace RPGManager.Desktop.Domain.Entities.ClassesEntities;

public class Class : GameSystemEntityBase
{
    public Guid PrimaryAbilityScoreId { get; set; }
    public Guid HitDiceTypeId { get; set; }

    public string Name { get; set; }

    public byte MaxChoicesSkillProficiency { get; set; }

    public DiceType HitDiceType { get; set; }
    public AbilityScore PrimaryAbilityScore { get; set; }

    public ICollection<ClassSavingThrowProficiency> SavingThrowProficiencies { get; set; }
    public ICollection<ClassSkillProficiency> SkillProficiencyOptions { get; set; }
    public ICollection<ClassWeaponCategoryProficiency> WeaponProficiencies { get; set; }
    public ICollection<ClassArmorCategoryProficiency> ArmorTraining { get; set; }
    public ICollection<ClassStartingEquipmentOption> StartingEquipmentOptions { get; set; }
    public ICollection<ClassLevel> Levels { get; set; }
}