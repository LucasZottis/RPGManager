using RPGManager.Desktop.Domain.Entities.Base;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Ancestry;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Proficiency;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;

namespace RPGManager.Desktop.Domain.Entities.RaceEntities;

public class Race : GameSystemEntityBase
{
    public Guid? ParentRaceId { get; set; }

    public string Name { get; set; }
    public string? Description { get; set; }
    public float Speed { get; set; }
    public string CreatureType { get; set; }

    public Race? ParentRace { get; set; }
    public RaceSkillProficiencyChoice? SkillProficiencyChoice { get; set; }

    public ICollection<RaceTrait> Traits { get; set; }
    public ICollection<Race>? SubRaces { get; set; }
    public ICollection<RaceSizeOption>? SizeOptions { get; set; }
    public ICollection<Spell>? Spells { get; set; }
    public ICollection<RaceAncestry>? Ancestries { get; set; }

}