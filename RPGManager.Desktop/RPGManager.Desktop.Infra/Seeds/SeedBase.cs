using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;
using RPGManager.Desktop.Domain.Entities.GameSystems;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

namespace RPGManager.Desktop.Infra.Seeds;

public abstract class SeedBase
{
    protected IDictionary<string, Guid> GameSystemsId = new Dictionary<string, Guid> {
        { "DnD", Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> GameSystemVersionsId = new Dictionary<string, Guid> {
        { "521", Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> AbilitiesScoreId = new Dictionary<string, Guid> {
        { "STR", Guid.NewGuid() },
        { "DEX", Guid.NewGuid() },
        { "CON", Guid.NewGuid() },
        { "INT", Guid.NewGuid() },
        { "WIS", Guid.NewGuid() },
        { "CHA", Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> AlignmentsId = new Dictionary<string, Guid>
    {
        { "LG", Guid.NewGuid() },
        { "NG", Guid.NewGuid() },
        { "CG", Guid.NewGuid() },
        { "LN", Guid.NewGuid() },
        { "N",  Guid.NewGuid() },
        { "CN", Guid.NewGuid() },
        { "LE", Guid.NewGuid() },
        { "NE", Guid.NewGuid() },
        { "CE", Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> CurrencyTypesId = new Dictionary<string, Guid>
    {
        { "CP", Guid.NewGuid() },
        { "SP", Guid.NewGuid() },
        { "EP", Guid.NewGuid() },
        { "GP", Guid.NewGuid() },
        { "PP", Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> DamageTypesId = new Dictionary<string, Guid>
    {
        { "Acid",        Guid.NewGuid() },
        { "Bludgeoning", Guid.NewGuid() },
        { "Cold",        Guid.NewGuid() },
        { "Fire",        Guid.NewGuid() },
        { "Force",       Guid.NewGuid() },
        { "Lightning",   Guid.NewGuid() },
        { "Necrotic",    Guid.NewGuid() },
        { "Piercing",    Guid.NewGuid() },
        { "Poison",      Guid.NewGuid() },
        { "Psychic",     Guid.NewGuid() },
        { "Radiant",     Guid.NewGuid() },
        { "Slashing",    Guid.NewGuid() },
        { "Thunder",     Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> DiceTypesId = new Dictionary<string, Guid>
    {
        { "D4",  Guid.NewGuid() },
        { "D6",  Guid.NewGuid() },
        { "D8",  Guid.NewGuid() },
        { "D10", Guid.NewGuid() },
        { "D12", Guid.NewGuid() },
        { "D20", Guid.NewGuid() },
        { "D100", Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> LanguagesId = new Dictionary<string, Guid>
    {
        // Standard
        { "Common",            Guid.NewGuid() },
        { "CommonSign",        Guid.NewGuid() },
        { "Draconic",          Guid.NewGuid() },
        { "Dwarvish",          Guid.NewGuid() },
        { "Elvish",            Guid.NewGuid() },
        { "Giant",             Guid.NewGuid() },
        { "Gnomish",           Guid.NewGuid() },
        { "Goblin",            Guid.NewGuid() },
        { "Halfling",          Guid.NewGuid() },
        { "Orc",               Guid.NewGuid() },
        // Rare
        { "Abyssal",           Guid.NewGuid() },
        { "Celestial",         Guid.NewGuid() },
        { "DeepSpeech",        Guid.NewGuid() },
        { "Druidic",           Guid.NewGuid() },
        { "Infernal",          Guid.NewGuid() },
        { "Primordial",        Guid.NewGuid() },
        { "Sylvan",            Guid.NewGuid() },
        { "ThievesCant",       Guid.NewGuid() },
        { "Undercommon",       Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> LevelsId = new Dictionary<string, Guid>
{
    { "1",  Guid.NewGuid() },
    { "2",  Guid.NewGuid() },
    { "3",  Guid.NewGuid() },
    { "4",  Guid.NewGuid() },
    { "5",  Guid.NewGuid() },
    { "6",  Guid.NewGuid() },
    { "7",  Guid.NewGuid() },
    { "8",  Guid.NewGuid() },
    { "9",  Guid.NewGuid() },
    { "10", Guid.NewGuid() },
    { "11", Guid.NewGuid() },
    { "12", Guid.NewGuid() },
    { "13", Guid.NewGuid() },
    { "14", Guid.NewGuid() },
    { "15", Guid.NewGuid() },
    { "16", Guid.NewGuid() },
    { "17", Guid.NewGuid() },
    { "18", Guid.NewGuid() },
    { "19", Guid.NewGuid() },
    { "20", Guid.NewGuid() },
};

    protected IDictionary<string, Guid> SizesId = new Dictionary<string, Guid>
    {
        { "Tiny",       Guid.NewGuid() },
        { "Small",      Guid.NewGuid() },
        { "Medium",     Guid.NewGuid() },
        { "Large",      Guid.NewGuid() },
        { "Huge",       Guid.NewGuid() },
        { "Gargantuan", Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> SkillsId = new Dictionary<string, Guid>
    {
        { "Acrobatics",     Guid.NewGuid() },
        { "AnimalHandling", Guid.NewGuid() },
        { "Arcana",         Guid.NewGuid() },
        { "Athletics",      Guid.NewGuid() },
        { "Deception",      Guid.NewGuid() },
        { "History",        Guid.NewGuid() },
        { "Insight",        Guid.NewGuid() },
        { "Intimidation",   Guid.NewGuid() },
        { "Investigation",  Guid.NewGuid() },
        { "Medicine",       Guid.NewGuid() },
        { "Nature",         Guid.NewGuid() },
        { "Perception",     Guid.NewGuid() },
        { "Performance",    Guid.NewGuid() },
        { "Persuasion",     Guid.NewGuid() },
        { "Religion",       Guid.NewGuid() },
        { "SleightOfHand",  Guid.NewGuid() },
        { "Stealth",        Guid.NewGuid() },
        { "Survival",       Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> ArmorCategoriesId = new Dictionary<string, Guid>
    {
        { "Light",   Guid.NewGuid() },
        { "Medium",  Guid.NewGuid() },
        { "Heavy",   Guid.NewGuid() },
        { "Shield",  Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> WearableArmorsId = new Dictionary<string, Guid>
    {
        // Light
        { "PaddedArmor",        Guid.NewGuid() },
        { "LeatherArmor",       Guid.NewGuid() },
        { "StuddedLeatherArmor", Guid.NewGuid() },
        // Medium
        { "HideArmor",          Guid.NewGuid() },
        { "ChainShirt",         Guid.NewGuid() },
        { "ScaleMail",          Guid.NewGuid() },
        { "Breastplate",        Guid.NewGuid() },
        { "HalfPlateArmor",     Guid.NewGuid() },
        // Heavy
        { "RingMail",           Guid.NewGuid() },
        { "ChainMail",          Guid.NewGuid() },
        { "SplintArmor",        Guid.NewGuid() },
        { "PlateArmor",         Guid.NewGuid() },
        // Shield
        { "Shield",             Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> ShieldArmorsId = new Dictionary<string, Guid>
    {
        { "Shield",             Guid.NewGuid() },
    };

    public abstract IEnumerable<GameSystem> GetGameSystems();
    public abstract IEnumerable<GameSystemVersion> GetGameSystemVersions();
    public abstract IEnumerable<AbilityScore> GetAbilityScore();
    public abstract IEnumerable<Alignment> GetAlignments();
    public abstract IEnumerable<CurrencyType> GetCurrencyTypes();
    public abstract IEnumerable<CurrencyConversionRate> GetCurrencyConversionsRate();
    public abstract IEnumerable<DamageType> GetDamageTypes();
    public abstract IEnumerable<DiceType> GetDiceTypes();
    public abstract IEnumerable<Language> GetLanguages();
    public abstract IEnumerable<Level> GetLevels();
    public abstract IEnumerable<Size> GetSizes();
    public abstract IEnumerable<Skill> GetSkills();
    public abstract IEnumerable<ArmorCategory> GetArmorCategories();
    public abstract IEnumerable<WearableArmor> GetWearableArmors();
    public abstract IEnumerable<ShieldArmor> GetShieldArmors();
}