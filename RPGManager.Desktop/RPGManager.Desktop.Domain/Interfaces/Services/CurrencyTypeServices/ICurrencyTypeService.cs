using RPGManager.Desktop.Domain.DTOs.CurrencyTypes;
using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services.CurrencyTypeServices;

public interface ICurrencyTypeService : ICrudServiceBase<CurrencyType, CurrencyTypeRegisterDto, CurrencyTypeQueryDto>
{

}