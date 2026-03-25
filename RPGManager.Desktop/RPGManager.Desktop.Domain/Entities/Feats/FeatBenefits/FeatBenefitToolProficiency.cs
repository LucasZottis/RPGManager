using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;

namespace RPGManager.Desktop.Domain.Entities.Feats.FeatBenefits;

public class FeatBenefitToolProficiency
{
    public Guid FeatBenefitId { get; set; }
    public Guid ToolId { get; set; }

    public FeatBenefit FeatBenefit { get; set; }
    public Tool Tool { get; set; }
}