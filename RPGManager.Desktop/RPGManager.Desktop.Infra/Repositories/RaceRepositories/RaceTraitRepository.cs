using RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories.RaceRepositories;

public class RaceTraitRepository : RepositoryBase<RaceTrait>, IRaceTraitRepository
{
    public RaceTraitRepository( Context context ) : base( context )
    {
    }
}
