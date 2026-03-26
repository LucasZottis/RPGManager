using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.RaceEntities.Ancestry;

public class RaceAncestrySpell : EntityBase
{
    public Guid RaceAncestryId { get; set; }
    public Guid SpellId { get; set; }

    public RaceAncestry RaceAncestry { get; set; }
    public Spell Spell { get; set; }

    public ICollection<RaceAncestrySpellLevel>? Levels { get; set; }
}