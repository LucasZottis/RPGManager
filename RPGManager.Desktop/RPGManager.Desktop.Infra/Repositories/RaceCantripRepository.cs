using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class RaceCantripRepository : RepositoryBase<RaceCantrip>, IRaceCantripRepository
{
    public RaceCantripRepository( Context context ) : base( context )
    {
    }
}
