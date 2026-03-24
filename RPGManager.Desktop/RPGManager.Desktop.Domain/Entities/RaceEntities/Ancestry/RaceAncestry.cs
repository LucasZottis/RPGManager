using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.RaceEntities.Ancestry;

public class RaceAncestry : EntityBase
{
    public Guid RaceId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }

    public Race Race { get; set; }

    public ICollection<RaceAncestrySpell> Spells { get; set; }
}