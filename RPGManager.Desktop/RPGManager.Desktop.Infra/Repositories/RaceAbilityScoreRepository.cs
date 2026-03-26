using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class RaceAbilityScoreRepository : RepositoryBase<RaceAbilityScore>, IRaceAbilityScoreRepository
{
    public RaceAbilityScoreRepository( Context context ) : base( context )
    {
    }
}
