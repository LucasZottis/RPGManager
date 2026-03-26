using RPGManager.Desktop.Domain.Entities.Feats;
using RPGManager.Desktop.Domain.Models.Feats;

namespace RPGManager.Desktop.Application.Services;

public class FeatCategoryService : CrudServiceBase<FeatCategory, FeatCategoryRegisterDto, FeatCategoryQueryDto>, IFeatCategoryService
{
    public FeatCategoryService( IFeatCategoryRepository repository, IFeatCategoryMapper mapper ) : base( repository, mapper )
    {
    }
}
