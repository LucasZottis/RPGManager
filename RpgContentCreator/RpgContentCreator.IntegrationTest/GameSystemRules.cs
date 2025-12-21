using RpgContentCreator.Domain.Models;
using RpgContentCreator.Domain.Models.Items.Weapons;

namespace RpgContentCreator.IntegrationTest;

public class GameSystemRules
{
    //private readonly GameSystemModel _gameSystem;
    private readonly IDictionary<string, GameSystemModel> _systems;
    private readonly IDictionary<string, AbilityScoreModel> _abilities;
    private readonly IDictionary<string, DamageTypeModel> _damageTypes;
    private readonly IDictionary<string, WeaponCategoryModel> _weaponCategories;
    private readonly IDictionary<string, WeaponTypeModel> _weaponTypes;
    private readonly IDictionary<string, LanguageModel> _languages;
    private readonly IDictionary<string, SkillModel> _skills;

    public GameSystemRules()
    {
        _systems = new Dictionary<string, GameSystemModel>();
        _abilities = new Dictionary<string, AbilityScoreModel>();
        _damageTypes = new Dictionary<string, DamageTypeModel>();
        _weaponCategories = new Dictionary<string, WeaponCategoryModel>();
        _weaponTypes = new Dictionary<string, WeaponTypeModel>();
        _languages = new Dictionary<string, LanguageModel>();
        _skills = new Dictionary<string, SkillModel>();
    }

    public void AddGameSystem( string key, GameSystemModel gameSystem )
    {
        if ( _systems.ContainsKey( key ) )
            return;

        _systems.Add( key, gameSystem );
    }

    public void AddAbilityScore( string key, AbilityScoreModel value )
    {
        if ( _abilities.ContainsKey( key ) )
            return;

        _abilities.Add( key, value );
    }

    public void AddDamageType( string key, DamageTypeModel value )
    {
        if ( _damageTypes.ContainsKey( key ) )
            return;

        _damageTypes.Add( key, value );
    }

    public void AddWeaponCategory( string key, WeaponCategoryModel value )
    {
        if ( _weaponCategories.ContainsKey( key ) )
            return;

        _weaponCategories.Add( key, value );
    }

    public void AddWeaponType( string key, WeaponTypeModel value )
    {
        if ( _weaponTypes.ContainsKey( key ) )
            return;

        _weaponTypes.Add( key, value );
    }

    public void AddLanguage( string key, LanguageModel value )
    {
        if ( _languages.ContainsKey( key ) )
            return;

        _languages.Add( key, value );
    }

    public void AddSkill( string key, SkillModel value )
    {
        if ( _skills.ContainsKey( key ) )
            return;

        _skills.Add( key, value );
    }

    public GameSystemModel GetGameSystem( string key )
        => _systems[ key ];

    public AbilityScoreModel GetAbilityScore( string key )
        => _abilities[ key ];

    public DamageTypeModel GetDamageType( string key )
        => _damageTypes[ key ];
}