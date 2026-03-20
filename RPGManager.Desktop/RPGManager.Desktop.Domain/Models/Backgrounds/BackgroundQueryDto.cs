namespace RPGManager.Desktop.Domain.Models.Backgrounds;

public class BackgroundQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}