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

    protected IDictionary<string, Guid> WeaponCategoriesId = new Dictionary<string, Guid>
    {
        { "Simple",  Guid.NewGuid() },
        { "Martial", Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> WeaponMasteryPropertiesId = new Dictionary<string, Guid>
    {
        { "Cleave", Guid.NewGuid() },
        { "Graze",  Guid.NewGuid() },
        { "Nick",   Guid.NewGuid() },
        { "Push",   Guid.NewGuid() },
        { "Sap",    Guid.NewGuid() },
        { "Slow",   Guid.NewGuid() },
        { "Topple", Guid.NewGuid() },
        { "Vex",    Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> WeaponPropertiesId = new Dictionary<string, Guid>
    {
        { "Ammunition",  Guid.NewGuid() },
        { "Finesse",     Guid.NewGuid() },
        { "Heavy",       Guid.NewGuid() },
        { "Light",       Guid.NewGuid() },
        { "Loading",     Guid.NewGuid() },
        { "Range",       Guid.NewGuid() },
        { "Reach",       Guid.NewGuid() },
        { "Thrown",      Guid.NewGuid() },
        { "TwoHanded",   Guid.NewGuid() },
        { "Versatile",   Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> WeaponTypesId = new Dictionary<string, Guid>
    {
        { "Melee",  Guid.NewGuid() },
        { "Ranged", Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> WeaponsId = new Dictionary<string, Guid>
    {
        // Simple Melee
        { "Club",          Guid.NewGuid() },
        { "Dagger",        Guid.NewGuid() },
        { "Greatclub",     Guid.NewGuid() },
        { "Handaxe",       Guid.NewGuid() },
        { "Javelin",       Guid.NewGuid() },
        { "LightHammer",   Guid.NewGuid() },
        { "Mace",          Guid.NewGuid() },
        { "Quarterstaff",  Guid.NewGuid() },
        { "Sickle",        Guid.NewGuid() },
        { "Spear",         Guid.NewGuid() },
        // Simple Ranged
        { "Dart",          Guid.NewGuid() },
        { "LightCrossbow", Guid.NewGuid() },
        { "Shortbow",      Guid.NewGuid() },
        { "Sling",         Guid.NewGuid() },
        // Martial Melee
        { "Battleaxe",     Guid.NewGuid() },
        { "Flail",         Guid.NewGuid() },
        { "Glaive",        Guid.NewGuid() },
        { "Greataxe",      Guid.NewGuid() },
        { "Greatsword",    Guid.NewGuid() },
        { "Halberd",       Guid.NewGuid() },
        { "Lance",         Guid.NewGuid() },
        { "Longsword",     Guid.NewGuid() },
        { "Maul",          Guid.NewGuid() },
        { "Morningstar",   Guid.NewGuid() },
        { "Pike",          Guid.NewGuid() },
        { "Rapier",        Guid.NewGuid() },
        { "Scimitar",      Guid.NewGuid() },
        { "Shortsword",    Guid.NewGuid() },
        { "Trident",       Guid.NewGuid() },
        { "Warhammer",     Guid.NewGuid() },
        { "WarPick",       Guid.NewGuid() },
        { "Whip",          Guid.NewGuid() },
        // Martial Ranged
        { "Blowgun",       Guid.NewGuid() },
        { "HandCrossbow",  Guid.NewGuid() },
        { "HeavyCrossbow", Guid.NewGuid() },
        { "Longbow",       Guid.NewGuid() },
        { "Musket",        Guid.NewGuid() },
        { "Pistol",        Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> GearsId = new Dictionary<string, Guid>
    {
        { "Acid",                Guid.NewGuid() },
        { "AlchemistsFire",      Guid.NewGuid() },
        { "Antitoxin",           Guid.NewGuid() },
        { "Backpack",            Guid.NewGuid() },
        { "BallBearings",        Guid.NewGuid() },
        { "Barrel",              Guid.NewGuid() },
        { "Basket",              Guid.NewGuid() },
        { "Bedroll",             Guid.NewGuid() },
        { "Bell",                Guid.NewGuid() },
        { "Blanket",             Guid.NewGuid() },
        { "BlockAndTackle",      Guid.NewGuid() },
        { "Book",                Guid.NewGuid() },
        { "BottleGlass",         Guid.NewGuid() },
        { "Bucket",              Guid.NewGuid() },
        { "BurglarsPack",        Guid.NewGuid() },
        { "Caltrops",            Guid.NewGuid() },
        { "Candle",              Guid.NewGuid() },
        { "CaseCrossbowBolt",    Guid.NewGuid() },
        { "CaseMapOrScroll",     Guid.NewGuid() },
        { "Chain",               Guid.NewGuid() },
        { "Chest",               Guid.NewGuid() },
        { "ClimbersKit",         Guid.NewGuid() },
        { "ClothesFine",         Guid.NewGuid() },
        { "ClothesTravelers",    Guid.NewGuid() },
        { "ComponentPouch",      Guid.NewGuid() },
        { "Costume",             Guid.NewGuid() },
        { "Crowbar",             Guid.NewGuid() },
        { "DiplomatsPack",       Guid.NewGuid() },
        { "DungeoneersPack",     Guid.NewGuid() },
        { "EntertainersPack",    Guid.NewGuid() },
        { "ExplorersPack",       Guid.NewGuid() },
        { "Flask",               Guid.NewGuid() },
        { "GrapplingHook",       Guid.NewGuid() },
        { "HealersKit",          Guid.NewGuid() },
        { "HolyWater",           Guid.NewGuid() },
        { "HuntersTrap",         Guid.NewGuid() },
        { "Ink",                 Guid.NewGuid() },
        { "InkPen",              Guid.NewGuid() },
        { "Jug",                 Guid.NewGuid() },
        { "Ladder",              Guid.NewGuid() },
        { "Lamp",                Guid.NewGuid() },
        { "LanternBullseye",     Guid.NewGuid() },
        { "LanternHooded",       Guid.NewGuid() },
        { "Lock",                Guid.NewGuid() },
        { "MagnifyingGlass",     Guid.NewGuid() },
        { "Manacles",            Guid.NewGuid() },
        { "Map",                 Guid.NewGuid() },
        { "Mirror",              Guid.NewGuid() },
        { "Net",                 Guid.NewGuid() },
        { "Oil",                 Guid.NewGuid() },
        { "Paper",               Guid.NewGuid() },
        { "Parchment",           Guid.NewGuid() },
        { "Perfume",             Guid.NewGuid() },
        { "Pole",                Guid.NewGuid() },
        { "PotionOfHealing",     Guid.NewGuid() },
        { "Pouch",               Guid.NewGuid() },
        { "Quiver",              Guid.NewGuid() },
        { "RamPortable",         Guid.NewGuid() },
        { "Rations",             Guid.NewGuid() },
        { "Robe",                Guid.NewGuid() },
        { "Rope",                Guid.NewGuid() },
        { "Sack",                Guid.NewGuid() },
        { "ScholarsPack",        Guid.NewGuid() },
        { "Shovel",              Guid.NewGuid() },
        { "SignalWhistle",       Guid.NewGuid() },
        { "SpellScrollCantrip",  Guid.NewGuid() },
        { "SpellScrollLevel1",   Guid.NewGuid() },
        { "SpikesIron",          Guid.NewGuid() },
        { "Spyglass",            Guid.NewGuid() },
        { "String",              Guid.NewGuid() },
        { "Tent",                Guid.NewGuid() },
        { "Tinderbox",           Guid.NewGuid() },
        { "Torch",               Guid.NewGuid() },
        { "Vial",                Guid.NewGuid() },
        { "Waterskin",           Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> AmmunitionTypesId = new Dictionary<string, Guid>
    {
        { "Arrow", Guid.NewGuid() },
        { "Bolt", Guid.NewGuid() },
        { "Firearm Bullet", Guid.NewGuid() },
        { "Sling Bullet", Guid.NewGuid() },
        { "Needle", Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> ToolCategoriesId = new Dictionary<string, Guid>
    {
        { "ArtisansTools", Guid.NewGuid() },
        { "OtherTools", Guid.NewGuid() },
    };

    protected IDictionary<string, Guid> ToolsId = new Dictionary<string, Guid>
    {
        { "AlchemistsSupplies", Guid.NewGuid() },
        { "BrewersSupplies", Guid.NewGuid() },
        { "CalligraphersSupplies", Guid.NewGuid() },
        { "CarpentersTools", Guid.NewGuid() },
        { "CartographersTools", Guid.NewGuid() },
        { "CobblersTools", Guid.NewGuid() },
        { "CooksUtensils", Guid.NewGuid() },
        { "GlassblowersTools", Guid.NewGuid() },
        { "JewelersTools", Guid.NewGuid() },
        { "LeatherworkersTools", Guid.NewGuid() },
        { "MasonsTools", Guid.NewGuid() },
        { "PaintersSupplies", Guid.NewGuid() },
        { "PottersTools", Guid.NewGuid() },
        { "SmithsTools", Guid.NewGuid() },
        { "TinkersTools", Guid.NewGuid() },
        { "WeaversTools", Guid.NewGuid() },
        { "WoodcarversTools", Guid.NewGuid() },
        { "DisguiseKit", Guid.NewGuid() },
        { "ForgeryKit", Guid.NewGuid() },
        { "GamingSet", Guid.NewGuid() },
        { "HerbalismKit", Guid.NewGuid() },
        { "MusicalInstrument", Guid.NewGuid() },
        { "NavigatorsTools", Guid.NewGuid() },
        { "PoisonersKit", Guid.NewGuid() },
        { "ThievesTools", Guid.NewGuid() },
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
    public abstract IEnumerable<WeaponCategory> GetWeaponCategories();
    public abstract IEnumerable<WeaponMasteryProperty> GetWeaponMasteryProperties();
    public abstract IEnumerable<WeaponProperty> GetWeaponProperties();
    public abstract IEnumerable<WeaponType> GetWeaponTypes();
    public abstract IEnumerable<Weapon> GetWeapons();
    public abstract IEnumerable<WeaponDamage> GetWeaponDamages();
    public abstract IEnumerable<WeaponPropertyAttribute> GetWeaponPropertyAttributes();
    public abstract IEnumerable<Gear> GetGears();
    public abstract IEnumerable<AmmunitionType> GetAmmunitionTypes();
    public abstract IEnumerable<ToolCategory> GetToolCategories();
    public abstract IEnumerable<Tool> GetTools();
}