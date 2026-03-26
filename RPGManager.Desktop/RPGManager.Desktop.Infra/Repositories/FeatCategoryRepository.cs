using RPGManager.Desktop.Domain.Entities.Feats;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class FeatCategoryRepository : RepositoryBase<FeatCategory>, IFeatCategoryRepository
{
    public FeatCategoryRepository( Context context ) : base( context )
    {
    }
}
