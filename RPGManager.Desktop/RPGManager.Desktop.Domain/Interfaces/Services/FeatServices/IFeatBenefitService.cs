using RPGManager.Desktop.Domain.DTOs.Feats;
using RPGManager.Desktop.Domain.Entities.Feats.FeatBenefits;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services.FeatServices;

public interface IFeatBenefitService : ICrudServiceBase<FeatBenefit, FeatBenefitRegisterDto, FeatBenefitQueryDto>
{
}
