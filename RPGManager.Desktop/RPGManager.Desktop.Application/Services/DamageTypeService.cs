

using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.DamageTypes;

namespace RPGManager.Desktop.Application.Services;

public class DamageTypeService : CrudServiceBase<DamageType, DamageTypeRegisterDto, DamageTypeQueryDto>, IDamageTypeService
{
    public DamageTypeService( IDamageTypeRepository repository, IDamageTypeMapper mapper ) : base( repository, mapper )
    {
    }
}