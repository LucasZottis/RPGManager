namespace RPGManager.Desktop.Domain.Models.Races;

public class RaceTraitSpellQueryDto
{
    public Guid Id { get; set; }
    public Guid RaceTraitId { get; set; }
    public Guid SpellId { get; set; }
    public int? RequiredLevel { get; set; }
}
