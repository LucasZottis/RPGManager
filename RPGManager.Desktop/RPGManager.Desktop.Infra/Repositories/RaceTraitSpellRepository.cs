using RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class RaceTraitSpellRepository : RepositoryBase<RaceTraitSpell>, IRaceTraitSpellRepository
{
    public RaceTraitSpellRepository( Context context ) : base( context )
    {
    }
}
