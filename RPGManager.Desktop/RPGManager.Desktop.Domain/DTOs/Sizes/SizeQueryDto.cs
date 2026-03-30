namespace RPGManager.Desktop.Domain.DTOs.Sizes;

public class SizeQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public float MinHeight { get; set; }
    public float MaxHeight { get; set; }
}
