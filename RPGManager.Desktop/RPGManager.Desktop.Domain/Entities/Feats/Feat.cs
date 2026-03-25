using RPGManager.Desktop.Domain.Entities.Base;
using RPGManager.Desktop.Domain.Entities.Feats.FeatBenefits;

namespace RPGManager.Desktop.Domain.Entities.Feats;

public class Feat : GameSystemEntityBase
{
    public Guid FeatCategoryId { get; set; }

    public string Description { get; set; }
    public bool IsRepeatable { get; set; }

    public FeatCategory FeatCategory { get; set; }

    public IEnumerable<FeatBenefit> Benefits { get; set; }
}