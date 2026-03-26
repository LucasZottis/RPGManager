using RPGManager.Desktop.Domain.Entities.RaceEntities.Ancestry;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class RaceAncestryRepository : RepositoryBase<RaceAncestry>, IRaceAncestryRepository
{
    public RaceAncestryRepository( Context context ) : base( context )
    {
    }
}
