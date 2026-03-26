using RPGManager.Desktop.Domain.Entities.Feats.FeatBenefits;
using RPGManager.Desktop.Domain.Models.Feats;

namespace RPGManager.Desktop.Application.Services;

public class FeatBenefitService : CrudServiceBase<FeatBenefit, FeatBenefitRegisterDto, FeatBenefitQueryDto>, IFeatBenefitService
{
    public FeatBenefitService( IFeatBenefitRepository repository, IFeatBenefitMapper mapper ) : base( repository, mapper )
    {
    }
}
