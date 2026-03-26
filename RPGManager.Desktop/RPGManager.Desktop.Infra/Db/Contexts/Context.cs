using Microsoft.EntityFrameworkCore;
using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Entities.Backgrounds.BackgroundAbilityScores;
using RPGManager.Desktop.Domain.Entities.Backgrounds.Equipments;
using RPGManager.Desktop.Domain.Entities.Backgrounds.ToolProficiencies;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.Feature;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.SkillProficiency;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.StartingEquipment;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.ToolProficiency;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.WeaponProficiency;
using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;
using RPGManager.Desktop.Domain.Entities.Feats;
using RPGManager.Desktop.Domain.Entities.Feats.FeatBenefits;
using RPGManager.Desktop.Domain.Entities.ItemsEntities;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Ancestry;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Proficiency;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;
using RPGManager.Desktop.Infra.Db.Interfaces;

namespace RPGManager.Desktop.Infra.Db.Contexts;

public class Context : ContextBase
{
    public Context( IDbContextConfigurator dbContextConfigurator ) : base( dbContextConfigurator )
    {
    }

    // Root entities (global using covers RPGManager.Desktop.Domain.Entities)
    internal DbSet<AbilityScore> AbilityScore { get; set; }
    internal DbSet<Alignment> Alignment { get; set; }
    internal DbSet<DamageType> DamageType { get; set; }
    internal DbSet<DiceType> DiceType { get; set; }
    internal DbSet<Feature> Feature { get; set; }
    internal DbSet<GameSystem> GameSystem { get; set; }
    internal DbSet<Language> Language { get; set; }
    internal DbSet<Level> Level { get; set; }
    internal DbSet<Monster> Monster { get; set; }
    internal DbSet<Size> Size { get; set; }
    internal DbSet<Skill> Skill { get; set; }
    internal DbSet<Spell> Spell { get; set; }

    // Backgrounds
    internal DbSet<Background> Background { get; set; }
    internal DbSet<BackgroundSkillProficiency> BackgroundSkillProficiency { get; set; }
    internal DbSet<BackgroundToolProficiency> BackgroundToolProficiency { get; set; }
    internal DbSet<BackgroundAbilityScoreChoice> BackgroundAbilityScoreChoice { get; set; }
    internal DbSet<BackgroundAbilityScoreOption> BackgroundAbilityScoreOption { get; set; }
    internal DbSet<BackgroundEquipmentOption> BackgroundEquipmentOption { get; set; }
    internal DbSet<BackgroundEquipmentOptionItem> BackgroundEquipmentOptionItem { get; set; }
    internal DbSet<BackgroundToolProficiencyChoice> BackgroundToolProficiencyChoice { get; set; }
    internal DbSet<BackgroundToolProficiencyOption> BackgroundToolProficiencyOption { get; set; }

    // Classes
    internal DbSet<Class> Class { get; set; }
    internal DbSet<SubClass> SubClass { get; set; }
    internal DbSet<ClassLevel> ClassLevel { get; set; }
    internal DbSet<ClassSpell> ClassSpell { get; set; }
    internal DbSet<ClassSavingThrowProficiency> ClassSavingThrowProficiency { get; set; }
    internal DbSet<ClassArmorCategoryProficiency> ClassArmorCategoryProficiency { get; set; }
    internal DbSet<ClassFeature> ClassFeature { get; set; }
    internal DbSet<ClassFeatureAttribute> ClassFeatureAttribute { get; set; }
    internal DbSet<ClassFeatureAttributeLevel> ClassFeatureAttributeLevel { get; set; }
    internal DbSet<ClassSkillProficiencyChoice> ClassSkillProficiencyChoice { get; set; }
    internal DbSet<ClassSkillProficiencyOption> ClassSkillProficiencyOption { get; set; }
    internal DbSet<ClassStartingEquipmentChoice> ClassStartingEquipmentChoice { get; set; }
    internal DbSet<ClassStartingEquipmentItem> ClassStartingEquipmentItem { get; set; }
    internal DbSet<ClassToolProficiencyChoice> ClassToolProficiencyChoice { get; set; }
    internal DbSet<ClassToolProficiencyOption> ClassToolProficiencyOption { get; set; }
    internal DbSet<ClassWeaponCategoryProficiency> ClassWeaponCategoryProficiency { get; set; }
    internal DbSet<ClassWeaponCategoryProficiencyCondition> ClassWeaponCategoryProficiencyCondition { get; set; }

    // Currency
    internal DbSet<CurrencyType> CurrencyType { get; set; }
    internal DbSet<CurrencyConversionRate> CurrencyConversionRate { get; set; }

    // Feats
    internal DbSet<FeatCategory> FeatCategory { get; set; }
    internal DbSet<Feat> Feat { get; set; }
    internal DbSet<FeatBenefit> FeatBenefit { get; set; }
    internal DbSet<FeatBenefitSkillProficiency> FeatBenefitSkillProficiency { get; set; }
    internal DbSet<FeatBenefitToolProficiency> FeatBenefitToolProficiency { get; set; }

    // Items
    internal DbSet<Item> Item { get; set; }
    internal DbSet<ArmorCategory> ArmorCategory { get; set; }
    internal DbSet<Armor> Armor { get; set; }
    internal DbSet<WearableArmor> WearableArmor { get; set; }
    internal DbSet<ShieldArmor> ShieldArmor { get; set; }
    internal DbSet<Gear> Gear { get; set; }
    internal DbSet<AmmunitionType> AmmunitionType { get; set; }
    internal DbSet<ToolCategory> ToolCategory { get; set; }
    internal DbSet<Tool> Tool { get; set; }
    internal DbSet<WeaponCategory> WeaponCategory { get; set; }
    internal DbSet<WeaponType> WeaponType { get; set; }
    internal DbSet<WeaponMasteryProperty> WeaponMasteryProperty { get; set; }
    internal DbSet<WeaponProperty> WeaponProperty { get; set; }
    internal DbSet<WeaponPropertyAttribute> WeaponPropertyAttribute { get; set; }
    internal DbSet<Weapon> Weapon { get; set; }
    internal DbSet<WeaponDamage> WeaponDamage { get; set; }
    internal DbSet<WeaponDamageDiceType> WeaponDamageDiceType { get; set; }

    // Races
    internal DbSet<Race> Race { get; set; }
    internal DbSet<RaceAbilityScore> RaceAbilityScore { get; set; }
    internal DbSet<RaceCantrip> RaceCantrip { get; set; }
    internal DbSet<RaceLanguage> RaceLanguage { get; set; }
    internal DbSet<RaceSizeOption> RaceSizeOption { get; set; }
    internal DbSet<RaceAncestry> RaceAncestry { get; set; }
    internal DbSet<RaceAncestrySpell> RaceAncestrySpell { get; set; }
    internal DbSet<RaceAncestrySpellLevel> RaceAncestrySpellLevel { get; set; }
    internal DbSet<RaceSkillProficiencyChoice> RaceSkillProficiencyChoice { get; set; }
    internal DbSet<RaceSkillProficiencyOption> RaceSkillProficiencyOption { get; set; }
    internal DbSet<RaceTrait> RaceTrait { get; set; }
    internal DbSet<RaceTraitSpell> RaceTraitSpell { get; set; }
    internal DbSet<RaceTraitSpellLevel> RaceTraitSpellLevel { get; set; }
}
