namespace RPGManager.Desktop.Application.Services;

public class CurrencyTypeService : ServiceBase<CurrencyType, CurrencyTypeModel>, ICurrencyTypeService
{
    public CurrencyTypeService( ICurrencyTypeRepository repository, ICurrencyTypeMapper mapper ) : base( repository, mapper )
    {
    }
}