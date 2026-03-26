namespace RPGManager.Desktop.Domain.Models.Feats;

public class FeatQueryDto
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public Guid FeatCategoryId { get; set; }
    public string Description { get; set; }
    public bool IsRepeatable { get; set; }
}
