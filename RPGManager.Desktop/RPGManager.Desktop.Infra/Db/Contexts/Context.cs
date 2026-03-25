using Microsoft.EntityFrameworkCore;
using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Infra.Db.Interfaces;

namespace RPGManager.Desktop.Infra.Db.Contexts;

public class Context : ContextBase
{
    public Context( IDbContextConfigurator dbContextConfigurator ) : base( dbContextConfigurator )
    {
    }

    internal DbSet<DiceType> DiceType { get; set; }
    internal DbSet<GameSystem> GameSystem { get; set; }
    internal DbSet<Race> Race { get; set; }
    internal DbSet<Class> Class { get; set; }
    internal DbSet<Background> Background { get; set; }
    //internal DbSet<AbilityScore> AbilityScore { get; set; }
    //internal DbSet<Language> Language { get; set; }
    //internal DbSet<Alignment> Alignment { get; set; }
    //internal DbSet<DamageType> DamageType { get; set; }
    //internal DbSet<CurrencyType> CurrencyType { get; set; }
    //internal DbSet<Skill> Skill { get; set; }
    //internal DbSet<WeaponCategory> WeaponCategory { get; set; }
    //internal DbSet<WeaponProperty> WeaponProperty { get; set; }
    //internal DbSet<Weapon> Weapon { get; set; }
    ////internal DbSet<WeaponProperties> PropertiesOfWeapon { get; set; }
    //internal DbSet<WeaponType> WeaponType { get; set; }
    ////internal DbSet<ArmorCategory> ArmorCategory { get; set; }
}