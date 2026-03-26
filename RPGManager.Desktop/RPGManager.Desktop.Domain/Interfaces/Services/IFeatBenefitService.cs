using RPGManager.Desktop.Domain.Entities.Feats.FeatBenefits;
using RPGManager.Desktop.Domain.Models.Feats;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IFeatBenefitService : ICrudServiceBase<FeatBenefit, FeatBenefitRegisterDto, FeatBenefitQueryDto>
{
}
