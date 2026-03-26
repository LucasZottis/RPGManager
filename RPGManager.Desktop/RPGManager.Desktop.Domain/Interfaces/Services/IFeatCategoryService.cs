using RPGManager.Desktop.Domain.Entities.Feats;
using RPGManager.Desktop.Domain.Models.Feats;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IFeatCategoryService : ICrudServiceBase<FeatCategory, FeatCategoryRegisterDto, FeatCategoryQueryDto>
{
}
