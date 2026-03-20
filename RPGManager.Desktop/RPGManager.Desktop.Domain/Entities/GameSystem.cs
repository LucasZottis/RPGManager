using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Domain.Entities.RaceEntities;

namespace RPGManager.Desktop.Domain.Entities;

public class GameSystem : EntityBase
{
    public string Name { get; set; }

    public ICollection<Race> Races { get; set; }
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