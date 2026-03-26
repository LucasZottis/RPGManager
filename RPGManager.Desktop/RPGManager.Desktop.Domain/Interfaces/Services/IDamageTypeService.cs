using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models.DamageTypes;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IDamageTypeService : ICrudServiceBase<DamageType, DamageTypeRegisterDto, DamageTypeQueryDto>
{
}
