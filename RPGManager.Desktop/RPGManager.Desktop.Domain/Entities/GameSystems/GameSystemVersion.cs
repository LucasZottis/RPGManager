using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Entities.Base;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Domain.Entities.RaceEntities;

namespace RPGManager.Desktop.Domain.Entities.GameSystems;

public class GameSystemVersion : EntityBase
{
    public Guid GameSystemId { get; set; }
    
    public string Version { get; set; }
    public string? LegalInformation { get; set; }

    public GameSystem GameSystem { get; set; }

    public ICollection<Race> Races { get; set; }
    public ICollection<Class> Classes { get; set; }
    public ICollection<Background> Backgrounds { get; set; }
    public ICollection<Level> LevelUps { get; set; }
    public ICollection<AbilityScore> AbilityScores { get; set; }
    public ICollection<Alignment> Alignments { get; set; }
    public ICollection<CurrencyType> CurrencyTypes { get; set; }
    public ICollection<DamageType> DamageTypes { get; set; }
    public ICollection<Language> Languages { get; set; }
    public ICollection<Skill> Skills { get; set; }
    public ICollection<WeaponCategory> WeaponCategories { get; set; }
    public ICollection<WeaponType> WeaponTypes { get; set; }
    public ICollection<WeaponProperty> WeaponProperties { get; set; }
    public ICollection<Weapon> Weapons { get; set; }
}