namespace RPGManager.Desktop.Domain.Entities.Feats.FeatBenefits;

public class FeatBenefitSkillProficiency
{
    public Guid FeatBenefitId { get; set; }
    public Guid SkillId { get; set; }

    public FeatBenefit FeatBenefit { get; set; }
    public Skill Skill { get; set; }
}