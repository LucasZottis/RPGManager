using RPGManager.Desktop.Domain.DTOs.DamageTypes;
using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IDamageTypeService : ICrudServiceBase<DamageType, DamageTypeRegisterDto, DamageTypeQueryDto>
{
}
