namespace RPGManager.Desktop.Domain.Entities.RaceEntities.Ancestry;

public class RaceAncestrySpellLevel
{
    public Guid RaceAncestrySpellId { get; set; }
    public Guid LevelId { get; set; }

    public RaceAncestrySpell RaceAncestrySpell { get; set; }
    public Level Level { get; set; }
}