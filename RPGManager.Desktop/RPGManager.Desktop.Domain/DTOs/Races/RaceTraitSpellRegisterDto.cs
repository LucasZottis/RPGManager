namespace RPGManager.Desktop.Domain.DTOs.Races;

public class RaceTraitSpellRegisterDto
{
    public Guid RaceTraitId { get; set; }
    public Guid SpellId { get; set; }
    public int? RequiredLevel { get; set; }
}
