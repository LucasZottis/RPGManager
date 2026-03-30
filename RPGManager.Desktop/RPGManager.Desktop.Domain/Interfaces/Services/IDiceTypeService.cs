using RPGManager.Desktop.Domain.DTOs.Dices;
using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IDiceTypeService : ICrudServiceBase<DiceType, DiceTypeRegisterDto, DiceTypeQueryDto>
{

}