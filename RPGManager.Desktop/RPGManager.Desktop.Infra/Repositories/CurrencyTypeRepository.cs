using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class CurrencyTypeRepository : RepositoryBase<CurrencyType>, ICurrencyTypeRepository
{
    public CurrencyTypeRepository( Context context ) : base( context )
    {
    }
}