namespace RPGManager.Desktop.Domain.Models.Languages;

public class LanguageQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Alphabet { get; set; }
}
