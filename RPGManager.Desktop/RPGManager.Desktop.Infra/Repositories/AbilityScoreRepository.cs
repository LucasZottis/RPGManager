using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class AbilityScoreRepository : RepositoryBase<Background>, IAbilityScoreRepository
{
    public AbilityScoreRepository( Context context ) : base( context )
    {
    }
}