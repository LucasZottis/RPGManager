using RPGManager.Desktop.Domain.Entities.Feats;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class FeatRepository : RepositoryBase<Feat>, IFeatRepository
{
    public FeatRepository( Context context ) : base( context )
    {
    }
}
