using RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class RaceTraitSpellLevelRepository : RepositoryBase<RaceTraitSpellLevel>, IRaceTraitSpellLevelRepository
{
    public RaceTraitSpellLevelRepository( Context context ) : base( context )
    {
    }
}
