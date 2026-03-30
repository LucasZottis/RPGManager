namespace RPGManager.Desktop.Domain.DTOs.Languages;

public class LanguageQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Alphabet { get; set; }
}
