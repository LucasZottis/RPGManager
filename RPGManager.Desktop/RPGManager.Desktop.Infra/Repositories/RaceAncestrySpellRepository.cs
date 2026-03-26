using RPGManager.Desktop.Domain.Entities.RaceEntities.Ancestry;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class RaceAncestrySpellRepository : RepositoryBase<RaceAncestrySpell>, IRaceAncestrySpellRepository
{
    public RaceAncestrySpellRepository( Context context ) : base( context )
    {
    }
}
