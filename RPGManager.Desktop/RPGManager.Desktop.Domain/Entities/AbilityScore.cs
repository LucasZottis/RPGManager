using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;

namespace RPGManager.Desktop.Domain.Entities;

public class AbilityScore : GameSystemVersionEntityBase
{
    public string Name { get; set; }
    public string? Abbreviation { get; set; }
    public string? Description { get; set; }

    //public ICollection<Class> PrimaryClassAbilityScore { get; set; }
    //public ICollection<ClassSavingThrowProficiency> ClassSavingThrowProficiencies { get; set; }
    public ICollection<WeaponProperty> AlternativeAbilityScoreForWeaponProperties { get; set; }
    public ICollection<Skill> SkillsBaseAbilityScore { get; set; }

    public ICollection<ShieldArmor> ShieldArmorsRequiredAbilityScoreId { get; set; }
    public ICollection<WearableArmor> WearableArmorsRequiredAbilityScoreId { get; set; }

    public ICollection<Tool>? ToolsCheck { get; set; }
    public ICollection<WearableArmor> WearableArmorClassesAbilitycoreModifiers { get; set; }
    public ICollection<Weapon> Weapons { get; set; }
}