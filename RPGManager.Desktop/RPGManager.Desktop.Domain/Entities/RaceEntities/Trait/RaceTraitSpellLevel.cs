namespace RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;

public class RaceTraitSpellLevel
{
    public Guid RaceTraitSpellId { get; set; }
    public Guid LevelId { get; set; }

    public RaceTraitSpell RaceTraitSpell { get; set; }
    public Level Level { get; set; }
}