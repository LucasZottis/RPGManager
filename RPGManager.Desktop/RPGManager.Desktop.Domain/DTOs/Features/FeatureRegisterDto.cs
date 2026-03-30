namespace RPGManager.Desktop.Domain.DTOs.Features;

public class FeatureRegisterDto
{
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}
