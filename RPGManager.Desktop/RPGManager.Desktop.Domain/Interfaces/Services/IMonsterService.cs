using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models.Monsters;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IMonsterService : ICrudServiceBase<Monster, MonsterRegisterDto, MonsterQueryDto>
{
}
