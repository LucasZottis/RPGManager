using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.CurrencyTypes;
using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;
using RPGManager.Desktop.Domain.Interfaces.Services.CurrencyTypeServices;

namespace RPGManager.Desktop.Application.Services.CurrencyTypeServices;

public class CurrencyTypeService : CrudServiceBase<CurrencyType, CurrencyTypeRegisterDto, CurrencyTypeQueryDto>, ICurrencyTypeService
{
    public CurrencyTypeService( ICurrencyTypeRepository repository, ICurrencyTypeMapper mapper ) : base( repository, mapper )
    {
    }
}