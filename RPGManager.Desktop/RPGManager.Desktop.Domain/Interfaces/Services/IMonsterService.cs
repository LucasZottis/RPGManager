using RPGManager.Desktop.Domain.DTOs.Monsters;
using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IMonsterService : ICrudServiceBase<Monster, MonsterRegisterDto, MonsterQueryDto>
{
}
