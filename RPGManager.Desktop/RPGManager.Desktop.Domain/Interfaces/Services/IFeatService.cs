using RPGManager.Desktop.Domain.Entities.Feats;
using RPGManager.Desktop.Domain.Models.Feats;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IFeatService : ICrudServiceBase<Feat, FeatRegisterDto, FeatQueryDto>
{
}
