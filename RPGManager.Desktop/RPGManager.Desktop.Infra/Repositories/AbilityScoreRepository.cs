using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class AbilityScoreRepository : RepositoryBase<AbilityScore>, IAbilityScoreRepository
{
    public AbilityScoreRepository( Context context ) : base( context )
    {
    }
}