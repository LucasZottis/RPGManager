namespace RPGManager.Desktop.Domain.Models.Races;

public class RaceAncestrySpellQueryDto
{
    public Guid Id { get; set; }
    public Guid RaceAncestryId { get; set; }
    public Guid SpellId { get; set; }
}
