namespace RPGManager.Desktop.Domain.Entities;

public class Language : EntityBase
{    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Alphabet { get; set; }

    public GameSystem GameSystem { get; set; }
}