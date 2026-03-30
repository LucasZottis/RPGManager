namespace RPGManager.Desktop.Domain.DTOs.Feats;

public class FeatCategoryQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
}
