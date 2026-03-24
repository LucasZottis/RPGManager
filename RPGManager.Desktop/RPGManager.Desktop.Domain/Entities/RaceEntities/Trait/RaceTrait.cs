using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;

public class RaceTrait : EntityBase
{
    public Guid RaceId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int? RequiredLevel { get; set; }

    public ICollection<RaceTraitSpell>? Spells { get; set; }

    public Race Race { get; set; }
}