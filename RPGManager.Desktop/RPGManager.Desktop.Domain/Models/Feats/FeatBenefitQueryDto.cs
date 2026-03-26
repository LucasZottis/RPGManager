namespace RPGManager.Desktop.Domain.Models.Feats;

public class FeatBenefitQueryDto
{
    public Guid Id { get; set; }
    public Guid FeatId { get; set; }
    public string Description { get; set; }
    public byte? SkillProficiencyChoiceAmount { get; set; }
    public byte? ToolProficiencyChoiceAmount { get; set; }
}
