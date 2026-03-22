namespace RPGManager.Desktop.Domain.Entities.ClassesEntities;

public class Class : GameSystemEntityBase
{
    public Guid PrimaryAbilityScoreId { get; set; }
    public Guid HitDiceTypeId { get; set; }

    public string Name { get; set; }
    public byte SkillProficiencyAmount { get; set; }
    //public byte FixedHitPointPerLevel { get; set; }

    public DiceType HitDiceType { get; set; }
    public AbilityScore PrimaryAbilityScore { get; set; }

    public ICollection<ClassLevelUp> LevelUps { get; set; }
    public ICollection<ClassFeature> Features { get; set; }
    public ICollection<ClassLevelUpFeature> LevelUpsFeatures { get; set; }
    public ICollection<ClassSavingThrowProficiency> SavingThrowProficiencies { get; set; }
    public ICollection<ClassSkillProficiency> SkillProficiencies { get; set; }
    public ICollection<ClassWeaponCategoryProficiency> WeaponCategoryProficiencies { get; set; }
    public ICollection<ClassWeaponCategoryProficiencyCondition> WeaponCategoryProficiencyConditions { get; set; }
    public ICollection<ClassArmorCategoryProficiency> ArmorCategoryProficiencies { get; set; }
}