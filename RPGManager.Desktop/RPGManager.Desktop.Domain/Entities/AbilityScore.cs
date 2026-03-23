using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.Proficiencies;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Domain.Entities;

public class AbilityScore : GameSystemEntityBase
{
    public string Name { get; set; }
    public string? Abbreviation { get; set; }
    public string? Description { get; set; }

    public ICollection<Class> PrimaryClassAbilityScore { get; set; }
    public ICollection<ClassSavingThrowProficiency> ClassSavingThrowProficiencies { get; set; }
    public ICollection<Skill> SkillsBaseAbilityScore { get; set; }

    public ICollection<Weapon> Weapons { get; set; }
    public ICollection<WeaponProperty> AlternativeAbilityScoreForWeaponProperties { get; set; }
}