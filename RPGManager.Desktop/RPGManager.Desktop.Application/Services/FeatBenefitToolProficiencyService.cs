using RPGManager.Desktop.Domain.Entities.Feats.FeatBenefits;
using RPGManager.Desktop.Domain.Models.Feats;

namespace RPGManager.Desktop.Application.Services;

public class FeatBenefitToolProficiencyService : CrudServiceBase<FeatBenefitToolProficiency, FeatBenefitToolProficiencyRegisterDto, FeatBenefitToolProficiencyQueryDto>, IFeatBenefitToolProficiencyService
{
    public FeatBenefitToolProficiencyService( IFeatBenefitToolProficiencyRepository repository, IFeatBenefitToolProficiencyMapper mapper ) : base( repository, mapper )
    {
    }
}
