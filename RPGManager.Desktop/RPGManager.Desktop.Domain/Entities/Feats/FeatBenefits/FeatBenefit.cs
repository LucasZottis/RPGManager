using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.Feats.FeatBenefits;

public class FeatBenefit : EntityBase
{
    public Guid FeatId { get; set; }

    public string Description { get; set; }

    public Feat Feat { get; set; }
}