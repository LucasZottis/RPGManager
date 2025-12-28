using RPGManager.Desktop.Test.Integration.Rules.RulesCollections;

namespace RPGManager.Desktop.Test.Integration.Rules;

public class Dictionaries
{
    public GameSystemRuleCollection GamaSystem { get; private set; } = new();
    public AbilityScoreRuleCollection Abilities { get; private set; } = new();
    public LanguageRuleCollection Languages { get; private set; } = new();
    public SkillRuleCollection Skills { get; private set; } = new();
    public AlignmentRuleCollection Alignments { get; private set; } = new();
    public DamageTypeRuleCollection DamageTypes { get; private set; } = new();
    public WeaponCategoryRuleCollection WeaponCategories { get; private set; } = new();
    public WeaponTypeRuleCollection WeaponTypes { get; private set; } = new();
    public WeaponPropertyRuleCollection WeaponProperty { get; private set; } = new();
    public CurrencyTypeRuleCollection CurrencyTypes { get; private set; } = new();
    public WeaponRuleColllection Weapons { get; private set; } = new();
    public RaceRuleCollection Race { get; private set; } = new();
}