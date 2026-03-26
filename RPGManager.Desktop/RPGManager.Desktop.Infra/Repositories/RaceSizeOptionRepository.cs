using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class RaceSizeOptionRepository : RepositoryBase<RaceSizeOption>, IRaceSizeOptionRepository
{
    public RaceSizeOptionRepository( Context context ) : base( context )
    {
    }
}
