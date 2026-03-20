namespace RPGManager.Desktop.Domain.Models.Backgrounds;

public class BackgroundRegisterDto
{
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}