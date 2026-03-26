using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class CurrencyConversionRateRepository : RepositoryBase<CurrencyConversionRate>, ICurrencyConversionRateRepository
{
    public CurrencyConversionRateRepository( Context context ) : base( context )
    {
    }
}
