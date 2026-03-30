namespace RPGManager.Desktop.Domain.DTOs.Features;

public class FeatureQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}
