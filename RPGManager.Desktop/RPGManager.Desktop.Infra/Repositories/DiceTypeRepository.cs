using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class DiceTypeRepository : RepositoryBase<DiceType>, IDiceTypeRepository
{
    public DiceTypeRepository( Context context ) : base( context )
    {
    }
}