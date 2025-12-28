using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IDamageTypeService : IServiceBase<DamageType, DamageTypeModel>
{
    //Task<DamageTypeModel> Create( DamageTypeModel model );
}