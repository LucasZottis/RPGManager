using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models.Dices;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IDiceTypeService : ICrudServiceBase<DiceType, DiceTypeRegisterDto, DiceTypeQueryDto>
{

}