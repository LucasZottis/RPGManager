namespace RPGManager.Desktop.Domain.Models.Feats;

public class FeatRegisterDto
{
    public Guid GameSystemId { get; set; }
    public Guid FeatCategoryId { get; set; }
    public string Description { get; set; }
    public bool IsRepeatable { get; set; }
}
