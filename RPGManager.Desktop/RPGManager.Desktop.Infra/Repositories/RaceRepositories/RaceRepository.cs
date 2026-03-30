using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories.RaceRepositories;

public class RaceRepository : RepositoryBase<Race>, IRaceRepository
{
    public RaceRepository( Context context ) : base( context ) { }
}