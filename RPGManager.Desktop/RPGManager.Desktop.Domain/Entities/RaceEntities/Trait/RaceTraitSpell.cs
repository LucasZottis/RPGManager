using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;

public class RaceTraitSpell : EntityBase
{
    public Guid RaceTraitId { get; set; }
    public Guid SpellId { get; set; }

    public int? RequiredLevel { get; set; }  // null = concedida no nível 1

    public RaceTrait RaceTrait { get; set; }
    public Spell Spell { get; set; }
}