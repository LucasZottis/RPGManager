using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class SpellRepository : RepositoryBase<Spell>, ISpellRepository
{
    public SpellRepository( Context context ) : base( context )
    {
    }
}
