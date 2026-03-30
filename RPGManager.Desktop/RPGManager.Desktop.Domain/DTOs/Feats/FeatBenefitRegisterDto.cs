namespace RPGManager.Desktop.Domain.DTOs.Feats;

public class FeatBenefitRegisterDto
{
    public Guid FeatId { get; set; }
    public string Description { get; set; }
    public byte? SkillProficiencyChoiceAmount { get; set; }
    public byte? ToolProficiencyChoiceAmount { get; set; }
}
